﻿using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.DAO
{
    public interface ICollectionDAO
    {
        void CreateCollection(Collection collection);
        List<Collection> GetAllUserCollections(int userId);
    }
}