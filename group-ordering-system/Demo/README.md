# Group Ordering System

## Files
| Pages | Files | database-write | database-read |
|-------|-------|----------------|---------------|
| LogIn / LogOut | `Form1.cs`,`LogIn.cs` |  |  |
| Order | `Order.cs` | `Consumption.txt` | `Deposit.txt`,`Restaurant.txt` |
| Booking | `Booking.cs` | `Booking.txt`,`Order.txt` | `Restaurant.txt`,`Consumption.txt` |
| Restaurant | `Restaurant.cs` | `Restaurant.txt` |  |
| Details | `Details.cs` | `Detail.txt`,`name.txt` | `Deposit.txt`,`Consumption.txt`,`Balance.txt` |
| Deposit | `Deposit.cs` | `Deposit.txt`,`Balance.txt` | `Consumption.txt` |
| People | `People.cs` | `People.txt` |  |
| Setting | `Setting.cs` | `Setting.txt` |  |


## Authentication
Level 👉 System > Manager > User
| Pages | Min Authentication |
|-------|----------------|
| LogIn / LogOut | User |
| Order | User |
| Booking | User |
| Restaurant | Manager |
| Details | Manager |
| Deposit | Manager |
| People | System |
| Setting | System |

## Account
| Authentication | Account | Password |
|----------------|---------|----------|
| User | User_01 | 3456 |
| Manager | Manager_01  | 5678 |
| System | System_01  | 1234 |
