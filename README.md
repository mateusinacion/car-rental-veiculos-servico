# Vehicle Service

Manages vehicle data and availability within the Car Rental system.

## Role in System

The Vehicle Service is responsible for maintaining vehicle information and
its operational status.

It provides availability data to the Rental Service, which uses this
information to allow or prevent rentals.

For full system context, refer to the Rental Service repository.

---

## Table: Vehicles

| Column          | Type   | Description              |
|-----------------|--------|--------------------------|
| id              | int    | Unique identifier        |
| model           | string | Vehicle model name       |
| license_plate   | string | Vehicle license plate    |
| renavam_number  | string | Brazilian registration   |
| status          | int    | Available / Unavailable  |

---

## Status

- `available` → Vehicle can be rented
- `unavailable` → Vehicle is rented or under maintenance

---

## API

- GET /api/Veiculos
- GET /api/Veiculos/{id}
- POST /api/Veiculos
- PUT /api/Veiculos/{id}
- PUT /api/Veiculos/AlterarStatus/{id}

## System Context

This service is part of the Car Rental Microservices System.

The Rental Service is the central service responsible for business rules
and orchestration.
