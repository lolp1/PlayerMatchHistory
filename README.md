# PlayerMatchHistory
 An example project to display match history of a player. 

# NOTES
* Just compile with visual studio 2022 with .NET 7.0 installed if you want to run locally.
* The service that populates the data is located in src/PlayerStatistics/Data/PlayerStatsService.cs
* This service is then injected into src/PlayerStatistics/Pages/FetchMatchHistory.razor to populate the html view. You can of course replace the service code with code to load a local mock database and use entity framework to access this data instead, but the goal was simple and practical for me and others to test and see.
* Did not spend time to test it on several devices (though it should work fine..). In a real project of course that is critical to ensure it's compatible with all browsers and devices.
