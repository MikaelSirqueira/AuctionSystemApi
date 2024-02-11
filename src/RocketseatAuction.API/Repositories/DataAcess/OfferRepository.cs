﻿using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Services;
using RocketseatAuction.API.UseCases.Offers.CreateOffer;

namespace RocketseatAuction.API.Repositories.DataAcess;

public class OfferRepository : IOfferRepository
{
    private readonly RocketseatAuctionDbContext _dbContext;

    public OfferRepository(RocketseatAuctionDbContext dbContext) => _dbContext = dbContext;


    public void Add(Offer offer)
    {
        _dbContext.Offers.Add(offer);

        _dbContext.SaveChanges();
    }
}