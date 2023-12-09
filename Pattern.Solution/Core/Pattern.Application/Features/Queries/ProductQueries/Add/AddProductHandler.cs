﻿using MediatR;
using Pattern.Application.Repositories.ProductRepositories;
using Pattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pattern.Application.Features.Queries.ProductQueries.Add
{
    public class AddProductHandler: IRequestHandler<AddProductRequest, AddProductResponse>
    {

        private readonly IProductWriteRepository _productWriteRepository;

        public AddProductHandler(IProductWriteRepository productWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
        }

        public Task<AddProductResponse> Handle(AddProductRequest request, CancellationToken cancellationToken)
        {
            var product = new Product()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Price = request.Price
            };

            _productWriteRepository.Add(product);
            _productWriteRepository.SaveChanges();

            return Task.FromResult(new AddProductResponse());

        }
    }
    
 }

