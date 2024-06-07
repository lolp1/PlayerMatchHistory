# PlayerMatchHistory
 An example project to display match history of a player. 

# NOTES
* Just compile with visual studio 2022 with .NET 7.0 installed if you want to run locally.
* The service that populates the data is located in src/PlayerStatistics/Data/PlayerStatsService.cs
* This service is then injected into src/PlayerStatistics/Pages/FetchMatchHistory.razor to populate the html view. If you want to run it with local database using sqlite, view the other branch I made here https://github.com/lolp1/PlayerMatchHistory/tree/playerstats-sqlite 
* Did not spend time to test it on several devices (though it should work fine..). In a real project of course that is critical to ensure it's compatible with all browsers and devices.
