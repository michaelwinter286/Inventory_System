# Inventory_System
Inventory System designed to help manage inventory on family farm.

Features:
User Input:
  - Add Inventory
  - Edit Inventory (WIP) - Will be added once SQL database is created.
  - Delete Item (WIP) - Will be added once SQL database is created.
  - View Inventory

Reporting:
  - Error Log - Date/Time tracking
    
Data Storage: (External File data storage.)
  - Inventory - .csv (inventory.csv)
  - Error Log - .txt (ErrorLog.txt)


Feature Requirements:

  1. Master Loop
    - This feature is built into the Main Menu class (MainMenu.cs) in the Menu method (Menu()).
    - Once the program has completed a function or operation it will take you back to the Main Menu screen.
    
  2. Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program.
    - This feature can be found in the Main Menu tab under "option 4" lines 57 - 95.
    - How I implemented this feature was to call the "inventory.csv" file. I then took the columns in that file and made each column their own var. Those variables are       set to create a new List<string> for each column. This allowed me to then use both lists and pull them into a string array so that I can control the output             format of the "View Inventory" screen.
  
  3. Implement a log that records errors, invalid inputs, or other important events and writes them to a text file:
    - Any exceptions or invalid input such as a null value is recorded on an external file (ErrorLog.txt) These errors and invalid input are date/time stamped along         with what the error/exception is for future trouble shooting and debugging.
  
  4. Read data from an external file, such as text, JSON, CSV, etc and use that data in your application
    - I created an Error Log reporting feature on the Main Menu "option 5" lines 98- 133.
    - This allows the user to be able to view what errors have been made when they were done. This allow the user to not have to dig around in the files of their             computer to find the error log file.
    - I used StreamReader to access the file and display the contents on the screen. 
      
  
