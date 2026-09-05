
# Library & Product Management Suite (Bibliotheque Desktop App)

A Windows desktop application built for a coursework module, combining **two independent modules** in one solution: a library catalog (books & authors) and a product/parcel management tool. Built with C# WinForms.

> **Note:** this repo currently bundles two unrelated exercises (a library module and a product/parcel module) plus a leftover `Rectangle` sample project. See "What to fix" below before presenting this as a single portfolio project.

## Features

**Library module** (Entity Framework Code-First)
- Manage authors (`Auteur`) and books (`Ouvrage`), linked by a one-to-many relationship
- CRUD screens: `GestionBibliothequeEF`, `GestionOuvrageEF`

**Product / parcel module** (ADO.NET, raw SQL)
- Manage products (`Produit`): reference, designation, quantity, price
- Manage parcels/deliveries (`Colis`): tracking number, delivery date, quantity, linked product
- CRUD screens: `GestionProduits`, `GestionColis`, `GestionProduitMDC`

## Tech Stack
- C# / .NET Framework 4.8 (WinForms)
- Entity Framework (Code-First) for the library module
- ADO.NET (`System.Data.SqlClient`) for the product/parcel module
- Microsoft SQL Server / SQL Server Express

## Architecture
| Layer | Folder | Responsibility |
|---|---|---|
| Business objects | `Metier/` | `Auteur`, `Ouvrage`, `Produit`, `Colis` |
| Data access | `DAO/` | ADO.NET queries (product/parcel side) |
| Controllers | `Controller/` | Bridges the UI to the DAO layer |
| UI | `Vues/` | WinForms screens + MDI main menu |
| Sample/unrelated | `Rectangle/` | Standalone console exercise, unrelated to the app |

## Getting Started

### Prerequisites
- Visual Studio 2019+ with the ".NET desktop development" workload
- SQL Server or SQL Server Express
- NuGet package restore enabled (for Entity Framework)

### Setup
1. Clone the repository.
2. Create a SQL Server database (e.g. `BDCom2026Gr5`) for the product/parcel tables, and let Entity Framework generate the library schema on first run (Code-First).
3. Update the connection string in [`DAO/ConnexionVente.cs`](DAO/ConnexionVente.cs) and in the EF connection (`App.config`) to point to **your own** SQL Server instance.
4. Open `TPCoursGr05.sln` in Visual Studio, restore NuGet packages, build, and run.

## What to Fix Before Publishing
- [ ] **Hardcoded connection string** — `Server=localhost\SQLEXPRESS;...` should live in `App.config`, not in source
- [ ] **Remove or relocate the `Rectangle/` project** — it's an unrelated exercise and confuses the repo's purpose
- [ ] **Split the two modules** — consider two separate repos (`library-manager` and `product-parcel-manager`) or clearly separate them into two solutions if you want a focused portfolio piece
- [ ] **Rename the solution** — `TPCoursGr05.sln` is a generic coursework name; rename to something like `LibraryAndInventoryManager.sln`
- [ ] No screenshots or usage walkthrough yet

## License
Add a license of your choice (e.g. MIT) if you intend this to be public and reusable.
