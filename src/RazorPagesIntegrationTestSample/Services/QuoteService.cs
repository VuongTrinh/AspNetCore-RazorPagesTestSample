﻿using System.Threading.Tasks;

namespace RazorPagesIntegrationTestSample.Services
{
    // Quote ©1975 BBC: The Doctor (Tom Baker); Dr. Who: Planet of Evil
    // https://www.bbc.co.uk/programmes/p00pyrx6
    public class QuoteService : IQuoteService
    {
        public Task<string> GenerateQuote()
        {
            return Task.FromResult<string>(
                "Come on, Sarah. We've an appointment in London, " +
                "and we're already 30,000 years late.");
        }
    }
}
