# Coursework2Comp2001

The selected dataset centers around the topic of smoking, with a specific focus on Plymouth.
Smoking stands as a significant public health concern, ranking among the leading causes of death and illness across the United Kingdom.
Annually, approximately 78,000 individuals in the UK lose their lives due to smoking-related causes.

However, this particular dataset delves into a more localized perspective, presenting insights into the number of respondents from various Plymouth wards whoparticipated in the 2014 Health and Wellbeing Survey.
By examining this dataset, we aim to gain a better understanding of smoking patterns within the Plymouth community

# Linked Data Application
The Linked Data Application, developed using PhpStorm 2021.3, serves as a platform for showcasing a dataset sourced from Plymouth Data Place.
This dataset focuses on smoking statistics in Plymouth, collected during a survey conducted in 2014.

The application comprises several key PHP pages, each with a specific purpose. The 'index' page provides users with an informative overview of the Linked Data Application (LDA) and sets expectations for their interaction.
The 'table view' page presents a condensed dataset, displaying information for ten randomly selected locations within the Plymouth area. Lastly, the application offers a 'JSON-LD' format option, allowing users to access the RDF (Resource Description Framework) representation of the dataset.

You can explore the Linked Data Application by following this link: http://web.socem.plymouth.ac.uk/COMP2001/EKontokostas/Showcase/api/program mes


Notably, the application integrates external APIs to enhance its functionality. Mapbox API is utilized for mapping purposes, providing interactive titles, while Leaflet.JS JavaScript code controls the map's behavior.
The MapQuest Geocoding API is leveraged to obtain coordinates for mapping each data item accurately. Additionally, the Bootstrap library contributes to the application's interface, ensuring a user-friendly and responsive design.

# API
For the implementation of the RESTful API, I utilized Azure Data Studio to access the Microsoft SQL Server Database.
The RESTful API was developed in C# using the ASP.NET framework to store details about university programs. It supports the following HTTP methods: GET, POST, PUT, and DELETE.

I designed six tables for the database, implemented three stored procedures to handle CRUD functionality, created one trigger to update program details and archive old program information into an audit table, and developed one view to present administrators with student and program details.

The six tables I created include the 'Students' table for storing student names and IDs, the 'Programmes' table for program titles and program codes, and the 'Projects' table for project titles, descriptions, years, thumbnail image files, and poster image files.

One of the procedures I've implemented is the 'Create_Programme' stored procedure, which checks for the existence of a program before inserting it into the database. The other two procedures, 'Update' and 'Delete,' allow for editing and removal of program records.

With this comprehensive structure, my RESTful API enables efficient and versatile management of university program data.
