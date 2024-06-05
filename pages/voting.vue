<template>
	<link href="https://fonts.googleapis.com/css?family=Alata" rel="stylesheet" />
	<link href="https://fonts.cdnfonts.com/css/ethnocentric" rel="stylesheet" />
	<link rel="stylesheet" href="https://use.typekit.net/clw2vbx.css" />

	<div>
		<MobileMenu
			v-show="showMobileMenu"
			@closeMobileMenu="showMobileMenu = false"
		/>
		<Navbar @showMobileMenu="showMobileMenu = true" pageTitle="Voting" />
		<div class="textBox">
			<img
				src="/assets/images/stars-top-desktop.png"
				alt="Stars top"
				style="position: absolute; top: 0; left: 0; width: 100%; z-index: -101"
			/>
			<p>
				Here you can vote for a president. If you are not sure yet, fill in the
				voting guide first. Once you have voted, you can get points for this
				president on the quest page. At the end of the election, a final event
				will be held at the Pixel Playground in R10 Fontys Eindhoven.
			</p>
			<button>Voting Guide</button>
		</div>
		<div class="box" style="height: 310px; width: 400px; margin: 0 auto">
			<div id="presidentContainer">
				<div class="presidentItem">
					<h2>president human</h2>
					<img
						src="/assets/images/Emily.png "
						alt="The Human President"
						style="height: 200px"
					/>
					<button>Human</button>
				</div>
				<div class="presidentItem">
					<h2>president AI</h2>
					<img
						src="/assets/images/Maichael.png"
						alt="The AI President"
						style="height: 200px"
					/>
					<button>AI</button>
				</div>
			</div>
		</div>
	</div>
	<img
		src="/assets/images/stars-bottom-desktop.png"
		alt="Stars bottom"
		style="position: absolute; bottom: 0; left: 0; width: 100%; z-index: -101"
	/>
</template>

<script>
import "/assets/css/main.css"; // Import the main css
export default {
	data() {
		return {
			pageTitle: "votingPage",
			showMobileMenu: false,
		};
	},
};
</script>

<style>
body {
	background-color: #061929;
	color: white;
}

/* All buttons */
button {
	border: none;
	padding: 6px 16px;
	border-radius: 10px;
	font-weight: 900;

	margin: 0 auto;
	display: block;

	font-family: "video";
	font-style: normal;
}

/* Top Text */
.textBox {
	display: flex;
	flex-direction: column;
	margin: 20px;
}

/* Voting Guide Button */
.textBox button {
	width: 150px;
	height: 50px;
}

/* Voting Text */
.textBox p {
	font-family: "video";
	font-style: normal;
	font-weight: 350;
	margin-bottom: 1rem;
}

/* President Selection */
#presidentContainer {
	display: flex;
	flex-direction: row;
	justify-content: center;
}

.presidentItem {
	display: flex;
	flex-direction: column;
	margin-left: 10px;
	margin-right: 10px;
	text-align: center;
}

.presidentItem h2 {
	margin-top: 10px;
}
</style>
