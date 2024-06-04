<template>
	<link href="https://fonts.googleapis.com/css?family=Alata" rel="stylesheet" />
	<link href="https://fonts.cdnfonts.com/css/ethnocentric" rel="stylesheet" />
	<link rel="stylesheet" href="https://use.typekit.net/clw2vbx.css" />
	<div>
		<MobileMenu
			v-show="showMobileMenu"
			@closeMobileMenu="showMobileMenu = false"
			style="position: relative; z-index: 100"
		/>
		<Navbar
			pageTitle="Voting guide"
			@showMobileMenu="showMobileMenu = true"
			style="position: relative; z-index: 100"
		/>

		<img class="img-stars-top-mobile" src="/assets/images/stars-top.png" />
		<img
			class="img-stars-top-desktop"
			src="/assets/images/stars-top-desktop.png"
		/>
		<div class="div-maincontainer">
			<div class="white-box">
				<h1 class="h1-votingguide">{{ pageTitle }}</h1>
				<p class="p-votingguide">
					With this voting guide, you'll ultimately get a president who best
					suits your positions.
				</p>
				<div class="div-button">
					<NuxtLink to="/voting-guide" style="text-decoration: none"
						><button class="button-getstarted">Get started</button></NuxtLink
					>
				</div>
			</div>
		</div>
		<div class="div-stars-bottom">
			<img
				class="img-stars-bottom-mobile"
				src="/assets/images/stars-bottom.png"
			/>
			<img
				class="img-stars-bottom-desktop"
				src="/assets/images/stars-bottom-desktop.png"
			/>
		</div>
	</div>
</template>

<script>
import WhiteBox from "/components/WhiteBox.vue"; // Import the WhiteBox component
export default {
	components: {
		WhiteBox, // Register the WhiteBoxe component
	},
	data() {
		return {
			pageTitle: "Voting guide", // Set the pageTitle data property so you can import it in the HTML. It's basically a variable
			showMobileMenu: false,
		};
	},
};
</script>
