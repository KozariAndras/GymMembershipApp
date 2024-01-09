# Gym Membership Management Application

## Description
This application is designed to manage the members of a gym and their respective memberships. The program handles member details and their associated memberships.

## Features
- **Master Data Management Module:**
  - Allows adding new members, modifying member details, and a module for selling memberships.

## Member Details Recording:
- Unique Member Code (automatically generated)
- Name (Mandatory)
- Address (Mandatory)
- Phone Number / Mobile Number (Optional)
- Email Address (Optional)

## Supported Membership Types:
- Daily Pass (valid for 1-day access)
- Monthly Membership (valid for 30 days access)
- Annual Membership (valid for 1 year access)

## Available Data Filtering Options:
- Active Members: Lists details of members with valid memberships at the time of the query.
- Inactive Members: Details of members with no valid membership at the time of the query.
- Valid Memberships: Lists currently valid memberships at the time of the query.
- Expired Memberships: Lists memberships that are no longer valid at the time of the query.
- Purchased Memberships: Displays the purchased memberships of a selected member.
- Quantity of Sold Memberships: Displays a diagram broken down by months, showing the quantity of memberships sold.

## Installation
Follow these steps to set up the application locally:

1. Clone the repository: `git clone https://github.com/KozariAndras/GymMembershipApp.git`
2. Navigate to the project directory: `cd GymMembershipApp`
3. Create a local `.mdf` file for the application's database.
4. Update the connection string in the application:
   - Navigate to: `GymMembershipApp\KondiApp\GymManagerDatabase\model\`
   - Open the `Database.cs` file with the editor of your choice.
   - In the 28. line replace the connection string with your own connection string.

## Usage
- Ensure you have the necessary tools and runtime installed for .NET 7 .
- Open the project in your preferred IDE or editor compatible with .NET 7.
- Build and run the application using the respective commands or IDE tools.

## Technologies Used
- .NET 7
- Windows Forms
- Microsoft Entity Framework
