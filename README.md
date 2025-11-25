<h1 style="font-weight:700; margin-bottom:10px;">Vehicle Fleet Management System</h1>
<p style="color:#555; font-size:15px;">
This project is being developed as a complete vehicle fleet management system for a rent-a-car company. 
The application manages vehicles, reservations, maintenance schedules, and availability tracking.
</p>

<hr style="border:0; border-top:1px solid #ccc; margin:20px 0;">

<h2 style="color:#333;">Features</h2>

<h3 style="color:#1a73e8;">Vehicle Management</h3>
<ul style="line-height:1.6;">
  <li>Abstract <code>Vehicle</code> class</li>
  <li>Derived classes: <code>Car</code>, <code>Motorcycle</code>, <code>Van</code>, <code>Truck</code></li>
  <li>Status tracking: available, rented, reserved, under maintenance</li>
  <li>Expected return date when rented or under maintenance</li>
  <li>Specific fields per vehicle type (doors, gearbox, engine size, load, etc.)</li>
</ul>

<h3 style="color:#1a73e8;">Company Module</h3>
<ul style="line-height:1.6;">
  <li>Central <code>Company</code> class storing all vehicles</li>
  <li>Supports inserting, updating, and listing vehicles</li>
</ul>

<h3 style="color:#1a73e8;">User Interface</h3>
<ul style="line-height:1.6;">
  <li>Add new vehicles</li>
  <li>Change vehicle state</li>
  <li>View available vehicles with filters</li>
  <li>View vehicles in maintenance</li>
  <li>Calculate reservation price between dates</li>
  <li>Export all vehicle data to CSV</li>
</ul>

<h3 style="color:#1a73e8;">Reservation System</h3>
<ul style="line-height:1.6;">
  <li>Create and manage reservations</li>
  <li>Check availability based on the current date</li>
  <li>Calculate total income between two dates</li>
</ul>

<h3 style="color:#1a73e8;">Date Simulation</h3>
<ul style="line-height:1.6;">
  <li>Loads system date on first run</li>
  <li>Option to advance the date manually</li>
  <li>Checks vehicle status when date changes</li>
</ul>

<hr style="border:0; border-top:1px solid #ccc; margin:25px 0;">

<h2 style="color:#333;">Technologies</h2>
<ul style="line-height:1.6;">
  <li>C#</li>
  <li>Windows Forms</li>
  <li>CSV export</li>
</ul>
