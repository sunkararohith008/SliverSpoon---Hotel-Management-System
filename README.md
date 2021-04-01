# SliverSpoon---Hotel-Management-System
Project - Hotel Management System

Database Name - HotelManagementSystem (4 Tables - Customers, Staffs, Rooms, Reservations)

In this Sliver Spoon Hotel Management System project , we are having two Roles i.e Guest and StaffAdmin. In Hotel Management System, guests who will be booking rooms have access to only some selected information in the database. They can check Rooms Information to check regarding the room and also Staffs table , so that they can get information about the Hotel staff(like receptionist, manager, etc.)

Authentication and Authorization - 
Guest can only access some pages (Like Rooms and Staff Information)in the website but StaffAdmin can access all the pages in the website. 

Authorization : We are having four main web pages i.e Rooms, Staffs, Customers and reservations. 
- Rooms doesn’t have any restriction i.e. it can be accessible by everyone i.e Guest and StaffAdmin 
- Reservation have restriction i.e StaffAdmin has only accessible to that Web page.
- Customer have restriction i.e StaffAdmin has only accessible to that Web page.
- Staff doesn’t have any restriction .it can be accessible by everyone i.e Guest and StaffAdmin.

Implement Role Authorization 
- In HomeController.cs We have authorized the privacy policy which is accesbile by StaffAdmin and Guest.
- In the Guest Role, Reservations and Customers Links have been hidden from them.


Images - 
1. Design View Folder - Design View screenshots of all the tables (4 Tables - Customers, Staffs, Rooms, Reservations)
2. Web project Images - Screenshots of web pages 
