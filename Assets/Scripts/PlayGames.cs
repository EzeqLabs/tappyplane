using UnityEngine;
using System.Collections;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class PlayGames : MonoBehaviour {


	void Start () {
		PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder ().Build ();

		PlayGamesPlatform.InitializeInstance (config);
		PlayGamesPlatform.Activate ();

		Social.localUser.Authenticate ((bool sucess) => {
			
		});
	}

	void ShowLeaderboard(){
		PlayGamesPlatform.Instance.ShowLeaderboardUI(GPGIds.leaderboard_best_scores);
	}

	void PostLeaderboard (int score){
		Social.ReportScore(score, GPGIds.leaderboard_best_scores, (bool success) => {});
	}

	void ShowAchievements(){
		Social.ShowAchievementsUI ();
	}

	// PLAYING
	void AchievementRocks (int score){
		switch (score) {
			case 1:
				Social.ReportProgress(GPGIds.achievement_first_rocks, 100.0f, (bool success) => {});
				break;

			case 10:
				Social.ReportProgress(GPGIds.achievement_ten_rocks, 100.0f, (bool success) => {});
				break;

			case 20:
				Social.ReportProgress(GPGIds.achievement_youre_getting_better, 100.0f, (bool success) => {});
				break;

			case 30:
				Social.ReportProgress(GPGIds.achievement_thirty_rocks, 100.0f, (bool success) => {});
				break;

			case 40:
				Social.ReportProgress(GPGIds.achievement_forty_rocks, 100.0f, (bool success) => {});
				break;

			case 50:
				Social.ReportProgress(GPGIds.achievement_were_having_fun, 100.0f, (bool success) => {});
				break;

			case 60:
				Social.ReportProgress(GPGIds.achievement_sixty_rocks, 100.0f, (bool success) => {});
				break;

			case 70:
				Social.ReportProgress(GPGIds.achievement_seventy_rocks, 100.0f, (bool success) => {});
				break;

			case 80:
				Social.ReportProgress(GPGIds.achievement_its_becoming_difficult, 100.0f, (bool success) => {});
				break;

			case 90:
				Social.ReportProgress(GPGIds.achievement_ninety_rocks, 100.0f, (bool success) => {});
				break;

			case 100:
				Social.ReportProgress(GPGIds.achievement_best_pilot, 100.0f, (bool success) => {});
				break;
		}

	}

	void AchivementsCoins(int coins){
		PlayGamesPlatform.Instance.IncrementAchievement (GPGIds.achievement_5k, coins, (bool success) => {});
		PlayGamesPlatform.Instance.IncrementAchievement (GPGIds.achievement_10k, coins, (bool success) => {});
		PlayGamesPlatform.Instance.IncrementAchievement (GPGIds.achievement_30k, coins, (bool success) => {});
		PlayGamesPlatform.Instance.IncrementAchievement (GPGIds.achievement_50k, coins, (bool success) => {});
		PlayGamesPlatform.Instance.IncrementAchievement (GPGIds.achievement_150k, coins, (bool success) => {});
	}

	// SHOP
	void AchievementBluePlane (){
		Social.ReportProgress(GPGIds.achievement_blue_plane, 100.0f, (bool success) => {});
	}

	void AchievementGreyPlane (){
		Social.ReportProgress(GPGIds.achievement_grey_plane, 100.0f, (bool success) => {});
	}

	void AchievementPinkPlane (){
		Social.ReportProgress(GPGIds.achievement_pink_plane, 100.0f, (bool success) => {});
	}

	void AchievementPurplePlane (){
		Social.ReportProgress(GPGIds.achievement_purple_plane, 100.0f, (bool success) => {});
	}

	void AchievementOrangePlane (){
		Social.ReportProgress(GPGIds.achievement_orange_plane, 100.0f, (bool success) => {});
	}

	void AchievementRedPlane (){
		Social.ReportProgress(GPGIds.achievement_red_plane, 100.0f, (bool success) => {});
	}

	void AchievementYellowPlane (){
		Social.ReportProgress(GPGIds.achievement_yellow_plane, 100.0f, (bool success) => {});
	}
}