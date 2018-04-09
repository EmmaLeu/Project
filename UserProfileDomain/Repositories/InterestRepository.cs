﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Project.Core.Repositories;
using Project.UserProfileDomain.DAL;
using Project.UserProfileDomain.Models;

namespace Project.UserProfileDomain.Repositories {

    public interface IInterestRepository : IEntityRepository<Interest> {

        IList<UserInterest> GetUserInterests(string userId);

    }

    public class InterestRepository : IInterestRepository {

        readonly IUserProfileContext userProfileDbContext;

        public IList<Interest> All => throw new NotImplementedException();

        public InterestRepository(IUserProfileContext userProfileDbContext) {
            this.userProfileDbContext = userProfileDbContext ?? throw new ArgumentNullException(nameof(userProfileDbContext));
        }

        public IList<UserInterest> GetUserInterests(string userId) {
            if (string.IsNullOrWhiteSpace(userId))
                throw new ArgumentException($"Could not retrieve user interests. Invalid parameter value: '{userId}'.", nameof(userId));

            return userProfileDbContext.UserInterests.Where(ui => ui.UserId == userId).ToList();
        }

        public IList<Interest> AllIncluding(params Expression<Func<Interest, object>>[] includeProperties) {
            throw new NotImplementedException();
        }

        public void Delete(Interest entity) {
            throw new NotImplementedException();
        }

        public IList<Interest> Get(params Expression<Func<Interest, object>>[] filters) {
            throw new NotImplementedException();
        }

        public IList<Interest> GetIncluding(Expression<Func<Interest, object>>[] filters, Expression<Func<Interest, object>>[] includeProperties) {
            throw new NotImplementedException();
        }

        public void InsertOrUpdate(Interest entity) {
            throw new NotImplementedException();
        }

        public void Save() {
            throw new NotImplementedException();
        }
    }

}
