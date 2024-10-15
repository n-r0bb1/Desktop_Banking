Desktop Banking App
Overview
This Desktop Banking Application is a simple banking system designed to help users manage their accounts and transactions, offering features such as:

Currency Converter
Deposit Calculator
Money Transfer System (using SQL Database)
The application is developed using C# and Windows Forms, with a SQL database for storing and managing account and transaction data.

Features
Currency Converter
Allows users to convert between various currencies in real time. The app fetches exchange rates from a pre-configured data source (could be an API or a local file).

Deposit Calculator
A financial tool that calculates interest earnings on deposits based on user inputs (deposit amount, interest rate, duration).

Money Transfer

Transfer money between accounts (implemented with a SQL backend to store account balances and transaction logs).
Users can view their transaction history, including transfers made and received.
SQL Database Integration
The application uses an SQL database to store:

User account information (account number, name, balance).
Transaction history (transaction ID, source account, destination account, amount, date).
Interest rates for the deposit calculator.
Technology Stack
Language: C#
Framework: .NET Framework/Windows Forms
Database: SQL
UI: Windows Forms 

How to Run
Prerequisites
.NET Framework (or .NET Core) should be installed.
SQL Server or SQLite database engine.
Visual Studio (for development) or standalone application executable.
