<!-- This part of the component is rendered out on the screen when called. All visible header elements are in here -->
<template>
	<header>
		<div class="div-header-mobile">
			<h1 class="h1-head">{{ pageTitle }}</h1>
			<h2 class="h2-head" @click="showMobileMenu">[ MENU ]</h2>
		</div>
		<div class="div-header-desktop">
			<h1 class="h1-head">{{ pageTitle }}</h1>
			<h2 class="h2-head">Home</h2>
			<h2 class="h2-head">Voting</h2>
			<h2 class="h2-head">Voting Guide</h2>
			<h2 class="h2-head">Profile</h2>
		</div>
	</header>
</template>
<!-- End of the visible component -->

<script>
export default {
	props: {
		pageTitle: String, // The title of the page, passed in as a prop
	},
	methods: {
		showMobileMenu() {
			this.$emit("showMobileMenu"); // Emit the showMobileMenu event
		},
	},
};
</script>

<style>
/* Mobile Settings */
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
		text-align: end;
	}

	.img-stars-top-mobile {
		width: 100%;
		margin-top: -11rem;
		position: absolute;
		z-index: -1;
	}

	.img-stars-top-desktop {
		display: none;
	}
}

/* Desktop Settings */
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
		text-align: end;
	}

	.img-stars-top-desktop {
		width: 100vw;
		margin-top: -10rem;
		height: 30rem;
	}

	.img-stars-top-mobile {
		display: none;
	}
}
</style>
