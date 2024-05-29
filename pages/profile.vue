<template>
	<div class="background">
		<MobileMenu
			v-show="showMobileMenu"
			@closeMobileMenu="showMobileMenu = false"
		/>
		<Navbar @showMobileMenu="showMobileMenu = true" />

		<div class="profile-content">
			<div class="profile-content-1">
				<div class="white-box">
					<img src="/assests/profile.svg" alt="#" />
					<h2>Username</h2>
				</div>

				<div class="profile-divider" style="margin-bottom: 30px"></div>
			</div>

			<div class="profile-content-2">
				<div class="profile-container">
					<div class="box">
						<div class="profile-grid">
							<div>
								<p class="profile-header">AI president</p>
								<img src="/assests/ai-president.png" alt="" />
							</div>
							<div>
								<p class="profile-header">Human president</p>
								<img src="/assests/human-president.png" alt="" />
							</div>
						</div>
						<button class="profile-button">Choose a side</button>
					</div>
				</div>

				<div class="profile-divider" style="margin-bottom: 30px"></div>
			</div>

			<div class="profile-content-3">
				<div class="profile-container">
					<div class="profile-score">
						<div class="profile-background">
							<h3>69</h3>
							<p>
								Completed <br />
								quests
							</p>
						</div>
						<div class="profile-background">
							<h3>#1</h3>
							<p>Ranking</p>
						</div>
						<div class="profile-background">
							<h3>1000</h3>
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
import "@/assests/css/main.css"; // Import the main css
import "@/assests/css/profile.css"; // Import the profile css

export default {
	data() {
		return {
			showMobileMenu: false,
		};
	},
};
</script>

<style>
* {
	padding: 0;
	margin: 0;

	overflow: hidden;
	box-sizing: border-box;
}

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
