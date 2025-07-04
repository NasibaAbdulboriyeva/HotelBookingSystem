﻿using HotelBookingSystem.Domain.Enums;

namespace HotelBookingSystem.Application.Dtos.CardDtos;
public class CreateCardDto
{
    public string CardHolderName { get; set; }
    public int ExpiryMonth { get; set; }
    public int ExpiryYear { get; set; }
    public CardType Type { get; set; }
    public string CardNumberMasked { get; set; }
    public string CVV { get; set; }
    public long UserId { get; set; }
}
