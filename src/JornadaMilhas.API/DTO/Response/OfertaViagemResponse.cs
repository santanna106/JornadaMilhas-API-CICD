﻿namespace JornadaMilhas.API.DTO.Response;

public record OfertaViagemResponse(int Id, RotaResponse rota, PeriodoResponse periodo, double preco);

