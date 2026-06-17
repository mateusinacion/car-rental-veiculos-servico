# Serviço de Veículos

Gerencia os dados e a disponibilidade dos veículos dentro do sistema de Locação de Veículos.

## Papel no Sistema

O Serviço de Veículos é responsável por manter as informações dos veículos e
o seu status operacional.

Ele fornece os dados de disponibilidade ao Serviço de Locação, que utiliza essa
informação para permitir ou impedir locações.

Para o contexto completo do sistema, consulte o repositório do Serviço de Locação.

---

## Tabela: Veiculos

| Coluna   | Tipo   | Descrição                       |
|----------|--------|---------------------------------|
| Id       | int    | Identificador único             |
| Modelo   | string | Nome do modelo do veículo       |
| Placa    | string | Placa do veículo                |
| Renavam  | string | Registro nacional do veículo    |
| Status   | int    | Disponível / Indisponível       |

---

## Status

- `Disponivel` → O veículo pode ser locado
- `Indisponivel` → O veículo está locado ou em manutenção

---

## API

- GET /api/Veiculos
- GET /api/Veiculos/{id}
- POST /api/Veiculos
- PUT /api/Veiculos/{id}
- PUT /api/Veiculos/AlterarStatus/{id}

## Contexto do Sistema

Este serviço faz parte do Sistema de Microsserviços de Locação de Veículos.

O Serviço de Locação é o serviço central, responsável pelas regras de negócio
e pela orquestração.
