<template>
	<link href="https://fonts.googleapis.com/css?family=Alata" rel="stylesheet" />
	<link href="https://fonts.cdnfonts.com/css/ethnocentric" rel="stylesheet" />
	<link rel="stylesheet" href="https://use.typekit.net/clw2vbx.css" />

	<div class="background">
		<!-- These are the stars at the top of the page -->
		<img
			class="mobile-nav-stars-top"
			src="/assets/images/stars-top-desktop.png"
			alt=""
		/>
		<MobileMenu
			v-show="showMobileMenu"
			@closeMobileMenu="showMobileMenu = false"
		/>
		<!-- Mobile navigation menu with a few props. showMobileMenu will be set to false if close is pressed -->
		<Navbar @showMobileMenu="showMobileMenu = true" pageTitle="Profile" />
		<!-- Desktop navigation menu with a few props. pageTitle is the page you're on, showMobileMenu will be set to true if [MENU] is pressed  -->

		<!-- Main content of the page -->
		<div class="profile-content">
			<div class="profile-content-1">
				<div class="white-box">
					<!-- <img src="/assets/images/profile.svg" alt="#" /> -->
					<h2 class="profile-username">
						<!-- Username component with userId as prop. Hardcoded for now but needs to be dynamic in the future. UserID for now is 66573909a0114b0f369f5c2e -->
						<Username userId="66573909a0114b0f369f5c2e" />
					</h2>
				</div>

				<!-- Standard devider class -->
				<div class="profile-divider" style="margin-bottom: 30px"></div>
			</div>

			<!-- Box to show which president you've voted for.
       Hardcoded for now, needs to be dynamic in the future. -->
			<div class="profile-content-2">
				<div class="box" style="height: 350px; width: 400px; margin: 0 auto">
					<div id="presidentContainer">
						<div class="presidentItem">
							<!-- The "MAIchael" needs to be dynamic -->
							<!-- Name of the president -->
							<h2 style="margin-bottom: 1rem">MAIchael</h2>
							<!-- Which president you've voted for. -->
							<p style="margin-bottom: 1rem">You've voted for MAIchael</p>
							<!-- Image of the president of choice -->
							<img
								src="/assets/images/Maichael.png"
								alt="The AI President"
								style="height: 200px; margin-bottom: 1rem"
							/>
							<!-- <div>
								<button>AI</button>
							</div> -->
						</div>
					</div>
				</div>

				<div class="profile-divider" style="margin-bottom: 30px"></div>
			</div>

			<!-- 3 badges at the bottom. Hardcoded for now, needs to be dynamic -->
			<div class="profile-content-3">
				<div class="profile-container">
					<div class="profile-score">
						<div class="profile-background">
							<!-- The amount of completed quests -->
							<h3>0</h3>
							<p>
								Completed <br />
								quests
							</p>
						</div>
						<div class="profile-background">
							<!-- Your ranking, calculate this with the point -->
							<h3>#</h3>
							<p>Ranking</p>
						</div>
						<div class="profile-background">
							<h3>
								<!-- UserScore component (/components/UserScore.vue). userId prompt is hardcoded, needs to be dynamic -->
								<UserScore userId="66573909a0114b0f369f5c2e" />
							</h3>
							<p>
								Collected <br />
								Points
							</p>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
</template>

<script>
// Import the components and styles
import "/assets/css/main.css"; // Import the main css
import "/assets/css/profile.css"; // Import the profile css
import Username from "/components/Username.vue";
import UserScore from "~/components/UserScore.vue";

export default {
	data() {
		return {
			showMobileMenu: false, // Show mobile menu is false by default untill [MENU] is pressed
		};
	},
	// The 2 components for username and userscore
	components: {
		Username,
		UserScore,
	},
};
</script>

<style>
/* Styles */
* {
	padding: 0;
	margin: 0;

	overflow: hidden;
}

.background {
	z-index: 100;
	position: relative;
	/* height: 100dvh; */
}

.mobile-nav-stars-top {
	position: absolute;
	top: 0;
	left: 0;
	z-index: -100;
}

/* Mobile only */
@media only screen and (max-width: 768px) {
	.div-header-mobile {
		display: flex;
		justify-content: space-between;
		margin-right: 2rem;
		margin-left: 2rem;
		flex-direction: row;
	}

	.div-header-desktop {
		display: none;
	}

	.h1-head {
		color: white;
		font-family: ethnocentric;
		margin-bottom: 2rem;
		font-size: 32px;
		margin-top: 4rem;
	}

	.h2-head {
		color: white;
		font-family: alata;
		margin-bottom: 2rem;
		font-size: 32px;
		margin-top: 4rem;
	}

	.h1-votingguide {
		color: #344f65;
		font-family: ethnocentric;
		margin-bottom: 1rem;
		font-size: 43px;
		margin-top: 2rem;
	}

	.p-votingguide {
		color: black;
		font-family: video, serif;
		font-style: normal;
		font-weight: 400;
		font-size: 29px;
		margin-bottom: 5rem;
	}

	.div-progressbar {
		display: flex;
	}

	progress {
		border-radius: 58px;
		width: 100%;
		height: 22px;
		border-color: black;
		border-style: solid;
		margin-top: 2rem;
	}

	progress::-webkit-progress-bar {
		background-color: white;
		border-radius: 58px;
	}

	progress::-webkit-progress-value {
		background-color: #344f65;
		border-radius: 58px;
	}

	label {
		font-size: 20px;
		font-weight: bold;
		display: block;
		margin: 20px 0;
	}

	.button-getstarted {
		color: white;
		background-color: black;
		font-family: video, serif;
		font-style: normal;
		font-weight: 400;
		font-size: 20px;
		border: none;
		border-radius: 10px;
		margin-top: 8rem;
		padding: 0.5rem 2rem 0.5rem 2rem;
		width: fit-content;
	}

	.div-button {
		display: flex;
		justify-content: center;
	}

	.div-votingbuttons {
		display: flex;
		flex-direction: row;
		justify-content: space-between;
	}

	.button-agree {
		background-color: #17ba31;
		border: none;
		border-radius: 50%;
		display: flex;
		text-decoration: none;
		padding: 1.2rem;
	}

	.button-neither {
		background-color: #959595;
		border: none;
		border-radius: 50%;
		display: flex;
		text-decoration: none;
		padding: 1.2rem;
	}

	.button-disagree {
		background-color: #ba1717;
		border: none;
		border-radius: 50%;
		display: flex;
		text-decoration: none;
		padding: 1.2rem;
	}

	.div-voting-text {
		display: flex;
		flex-direction: row;
		justify-content: space-between;
		margin-left: 0.6rem;
		margin-top: 0.5rem;
	}

	.p-voting-text {
		font-family: video, serif;
		font-style: normal;
		font-weight: 400;
		font-size: 15px;
	}

	.p-voting-text2 {
		font-family: video, serif;
		font-style: normal;
		font-weight: 400;
		font-size: 15px;
		margin-left: 0.7rem;
	}

	.p-voting-text3 {
		font-family: video, serif;
		font-style: normal;
		font-weight: 400;
		font-size: 15px;
	}
}

/* Desktop only */
@media only screen and (min-width: 769px) {
	.div-header-desktop {
		display: flex;
		justify-content: space-evenly;
		margin-right: 2rem;
		flex-direction: row;
		position: relative;
	}

	.div-header-mobile {
		display: none;
	}

	.h1-head {
		color: white;
		font-family: ethnocentric;
		margin-bottom: 2rem;
		font-size: 64px;
		margin-top: 3rem;
		margin-left: 2rem;
		margin-right: 11rem;
	}

	.h2-head {
		color: white;
		font-family: alata;
		font-style: normal;
		font-weight: 300;
		margin-bottom: 2rem;
		font-size: 32px;
		margin-top: 4rem;
	}

	.h1-votingguide {
		color: #344f65;
		font-family: ethnocentric;
		margin-bottom: 2rem;
		font-size: 45px;
		margin-top: 4rem;
		margin-left: 4rem;
	}

	.p-votingguide {
		color: black;
		font-family: video, serif;
		font-style: normal;
		font-weight: 400;
		font-size: 33px;
		margin-left: 4rem;
		margin-right: 7rem;
	}

	.div-progressbar {
		display: flex;
	}

	progress {
		border-radius: 58px;
		width: 68%;
		height: 22px;
		border-color: black;
		border-style: solid;
		margin-top: 2rem;
		margin-left: 10rem;
	}

	progress::-webkit-progress-bar {
		background-color: white;
		border-radius: 58px;
	}

	progress::-webkit-progress-value {
		background-color: #344f65;
		border-radius: 58px;
	}

	label {
		font-size: 20px;
		font-weight: bold;
		display: block;
		margin: 20px 0;
	}

	.button-getstarted {
		color: white;
		background-color: black;
		font-family: video, serif;
		font-style: normal;
		font-weight: 400;
		font-size: 35px;
		border: none;
		border-radius: 10px;
		margin-top: 8rem;
		padding: 1rem 5rem;
		cursor: pointer;
	}

	.div-button {
		display: flex;
		justify-content: center;
	}

	.div-votingbuttons {
		display: flex;
		flex-direction: row;
		justify-content: space-evenly;
		margin-top: 6rem;
	}

	.button-agree {
		background-color: #17ba31;
		border: none;
		border-radius: 50%;
		display: flex;
		text-decoration: none;
		padding: 1.8rem;
		cursor: pointer;
	}

	.button-neither {
		background-color: #959595;
		border: none;
		border-radius: 50%;
		display: flex;
		text-decoration: none;
		padding: 1.8rem;
		cursor: pointer;
	}

	.button-disagree {
		background-color: #ba1717;
		border: none;
		border-radius: 50%;
		display: flex;
		text-decoration: none;
		padding: 1.8rem;
		cursor: pointer;
	}

	.div-voting-text {
		display: flex;
		flex-direction: row;
		justify-content: space-evenly;
		margin-left: 0.5rem;
		margin-top: 0.5rem;
	}

	.p-voting-text {
		font-family: video, serif;
		font-style: normal;
		font-weight: 400;
		font-size: 15px;
	}

	.p-voting-text2 {
		font-family: video, serif;
		font-style: normal;
		font-weight: 400;
		font-size: 15px;
		margin-left: 2rem;
	}

	.p-voting-text3 {
		font-family: video, serif;
		font-style: normal;
		font-weight: 400;
		font-size: 15px;
		margin-left: 1rem;
	}
}
</style>
