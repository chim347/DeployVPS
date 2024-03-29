﻿using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Infrastructure.Persistence.Interceptors
{
    public class AuditableEntitySaveChangesInterceptor : SaveChangesInterceptor
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public AuditableEntitySaveChangesInterceptor(ICurrentUserService currentUserService, IDateTime dateTime)
        {
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }

        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            UpdateEntities(eventData.Context);
            return base.SavingChanges(eventData, result);
        }

        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            UpdateEntities(eventData.Context);
            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }

        public void UpdateEntities(DbContext? context)
        {
            if (context == null) return;
            foreach(var entry in context.ChangeTracker.Entries<BaseAuditableEntity>()) {
                if (entry.State == EntityState.Added) {
                    entry.Entity.CreateBy = _currentUserService.UserId;
                    entry.Entity.Created = _dateTime.Now;
                }
                if(entry.State == EntityState.Added || entry.State == EntityState.Modified || entry.HasChangeOwnedEntities()) {
                    entry.Entity.LastModifiedBy = _currentUserService.UserId;
                    entry.Entity.LastModified = _dateTime.Now;
                }
            }
        }
    }
}

public static class Extensions
{
    public static bool HasChangeOwnedEntities(this EntityEntry entityEntry) =>
        entityEntry.References.Any(r =>
        r.TargetEntry != null &&
        r.TargetEntry.Metadata.IsOwned() &&
        (r.TargetEntry.State == EntityState.Added || r.TargetEntry.State == EntityState.Modified));
}