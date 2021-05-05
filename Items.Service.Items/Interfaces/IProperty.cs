﻿using Items.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Items.Service.Item.Interfaces
{
    public interface IProperty
    {
        Task<Guid> CreateAsync(PropertyDTO propertyDTO);

        IAsyncEnumerable<PropertyDTO> GetAllAsync();

        IAsyncEnumerable<PropertyDTO> GetByItemAsync(Guid itemId);

        Task<PropertyDTO> GetByIdAsync(Guid id);

    }
}
