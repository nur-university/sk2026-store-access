#!/bin/bash
OUTPUT_DIR="/d/NUR/Modulo2-2024/Example/nuget-repository"

./build-nuget.sh ./src/Nur.Store2026.Access.Contracts/Nur.Store2026.Access.Contracts.csproj $OUTPUT_DIR
./build-nuget.sh ./src/Nur.Store2026.Access.Catalog/Nur.Store2026.Access.Catalog.csproj $OUTPUT_DIR
./build-nuget.sh ./src/Nur.Store2026.Access.Inventory/Nur.Store2026.Access.Inventory.csproj $OUTPUT_DIR
./build-nuget.sh ./src/Nur.Store2026.Access.Identity/Nur.Store2026.Access.Identity.csproj $OUTPUT_DIR
./build-nuget.sh ./src/Nur.Store2026.Access.Orders/Nur.Store2026.Access.Orders.csproj $OUTPUT_DIR
./build-nuget.sh ./src/Nur.Store2026.Access.Payments/Nur.Store2026.Access.Payments.csproj $OUTPUT_DIR
./build-nuget.sh ./src/Nur.Store2026.Access/Nur.Store2026.Access.csproj $OUTPUT_DIR