<template>
	<div>
		<button class="mobile-close-button" @click="closeMobileMenu">
			[ CLOSE ]
		</button>
		<div class="box mobile-nav">
			<ul>
				<li><a href="#">Home</a></li>
				<hr />
				<li><a href="#">Quests</a></li>
				<hr />
				<li><a href="#">Voting Guide</a></li>
				<hr />
				<li><a href="#">Profile</a></li>
				<hr />
			</ul>
		</div>
		
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

	z-index: 1;
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
</style>
