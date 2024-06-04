<template>
	<div>
		<img
			class="mobile-nav-stars-top"
			src="/assets/images/stars-top.png"
			alt=""
		/>
		<button class="mobile-close-button" @click="closeMobileMenu">
			[ CLOSE ]
		</button>
		<div class="box mobile-nav">
			<ul>
				<li><a href="/home">Home</a></li>
				<hr />
				<li><a href="/voting">Voting</a></li>
				<hr />
				<li><a href="/voting-guide-get-started">Voting Guide</a></li>
				<hr />
				<li><a href="/profile">Profile</a></li>
				<hr />
			</ul>
		</div>
		<img
			src="/assets/images/stars-bottom.png"
			alt="Stars bottom"
			style="position: absolute; bottom: 0; left: 0; width: 100%; z-index: -101"
		/>
	</div>
</template>

<script>
export default {
	methods: {
		closeMobileMenu() {
			this.$emit("closeMobileMenu");
		},
	},
};
</script>

<style>
.mobile-close-button {
	position: absolute;
	top: 3rlh;
	right: 3rlh;
	z-index: 2;

	border: none;
	background-color: transparent;
	font-size: 32px;

	color: white;
	width: fit-content;
}
.mobile-nav-stars-top {
	position: absolute;
	top: 0;
	left: 0;
	width: 100%;

	z-index: 1;
}
.mobile-nav-stars-bottom {
	position: absolute;
	bottom: 0;
	left: 0;
	width: 100%;

	z-index: -10;
}
.mobile-nav {
	height: 100svh;
	max-width: 100dvw;

	box-sizing: border-box;

	padding: 3rlh;

	display: flex;
	flex-direction: column;
	justify-content: center;
}
.mobile-nav ul {
	list-style-type: none;
	display: flex;
	flex-direction: column;
	gap: 16px;
}
.mobile-nav ul li {
	text-transform: uppercase;
	font-weight: 900;
	font-family: ethnocentric;
}
.mobile-nav ul li a {
	text-decoration: none;
	color: white;
}

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
		width: 200px;
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
