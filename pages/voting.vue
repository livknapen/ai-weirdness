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
				Here you can vote for a president. If you are not sure yet, you can
				refer to the voting guide to help you make a decision.
			</p>
			<a href="/voting-guide-get-started"><button>Voting Guide</button></a>
		</div>
		<!-- Check if testState is true, if not skip this code -->
		<div
			class="box"
			style="height: 310px; width: 400px; margin: 0 auto"
			v-if="testState"
		>
			<div id="presidentContainer">
				<div class="presidentItem">
					<h2 style="margin-bottom: 1rem">Emily</h2>
					<img
						src="/assets/images/Emily.png "
						alt="The Human President"
						style="height: 200px; margin-bottom: 1rem"
					/>
					<button>Vote</button>
				</div>
				<div class="presidentItem">
					<h2 style="margin-bottom: 1rem">MAIchael</h2>
					<img
						src="/assets/images/Maichael.png"
						alt="The AI President"
						style="height: 200px; margin-bottom: 1rem"
					/>
					<div>
						<!-- Change the testState to whatever the opposite of it's current value is (false or true) -->
						<button @click="testState = !testState">Vote</button>
					</div>
				</div>
			</div>
		</div>

		<!-- Check if testState is false, this will only show if the vote button for MAIchael is pressed -->
		<div class="box" style="height: 350px; width: 400px; margin: 0 auto" v-else>
			<div id="presidentContainer">
				<div class="presidentItem">
					<h2 style="margin-bottom: 1rem">MAIchael</h2>
					<p style="margin-bottom: 1rem">You've voted for MAIchael</p>
					<img
						src="/assets/images/Maichael.png"
						alt="The AI President"
						style="height: 200px; margin-bottom: 1rem"
					/>
					<div>
						<!-- Change the testState to whatever the opposite of it's current value is (false or true) -->
						<button @click="testState = !testState">Undo vote</button>
					</div>
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
			pageTitle: "votingPage", // obsolete code, page title can be changed in the Navbar component props
			showMobileMenu: false, // Set the mobile menu to false, changes to true if the [MENU] button is pressed
			testState: true, // Set the testState to true, this will be used to toggle between the two voting options
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
.presidentItem img {
	border: 2px solid white;
}
</style>
