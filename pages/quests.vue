<template>
	<link href="https://fonts.googleapis.com/css?family=Alata" rel="stylesheet" />
	<link href="https://fonts.cdnfonts.com/css/ethnocentric" rel="stylesheet" />
	<link rel="stylesheet" href="https://use.typekit.net/clw2vbx.css" />
	<!-- Top background stars image -->
	<img class="stars-bg-top" src="/assets/images/stars.svg" alt="Stars" />

	<MobileMenu
		v-show="showMobileMenu"
		@closeMobileMenu="showMobileMenu = false"
		class="z-index-100"
	/>
	<Navbar
		pageTitle="Quests"
		@showMobileMenu="showMobileMenu = true"
		style="position: relative; z-index: 100"
	/>

	<!-- Header text section -->
	<div class="header-text">
		<h3>Choose a quest!</h3>
		<p>You can select different tasks with the arrows.</p>
	</div>

	<!-- Slideshow wrapper -->
	<div id="slideshow-wrap">
		<!-- Radio buttons for slideshow controls -->
		<input type="radio" id="button-1" name="controls" checked="checked" />
		<input type="radio" id="button-2" name="controls" />
		<input type="radio" id="button-3" name="controls" />

		<!-- Slideshow navigation arrows -->
		<label for="button-1" class="arrows" id="arrow-1">></label>
		<label for="button-2" class="arrows" id="arrow-2">></label>
		<label for="button-3" class="arrows" id="arrow-3">></label>

		<!-- Slideshow inner content -->
		<div id="slideshow-inner">
			<ul>
				<li id="slide1">
					<box-1 />
					<img src="/assets/images/quest1.svg" alt="Quests" />
				</li>
				<li id="slide2">
					<box-2 />
					<img src="/assets/images/quest2.svg" alt="Quests" />
				</li>
				<li id="slide3">
					<box-3 />
					<img src="/assets/images/quest3.svg" alt="Quests" />
				</li>
			</ul>
		</div>
	</div>

	<!-- Bottom background stars image -->
	<img
		class="stars-bg-bottom"
		src="/assets/images/stars-bottom.svg"
		alt="Stars"
	/>
</template>

<script>
export default {
	data() {
		return {
			showMobileMenu: false,
		};
	},
};
</script>

<style>
@import url("https://fonts.cdnfonts.com/css/ethnocentric");

/* General body styling */
body {
	background-color: #061929;
	margin: 0;
	padding: 0;
	font-family: "video";
	font-style: normal;
	font-weight: 350;
	background-repeat: repeat;
}

@media only screen and (max-width: 768px) {
	/* Top and bottom stars background positioning */
	.stars-bg-top {
		position: absolute;
		margin-top: -50px;
	}

	.stars-bg-bottom {
		position: absolute;
	}

	/* Header text styling */
	.header-text {
		margin: 0vw 10vw;
	}

	/* General text styling */
	h3 {
		color: white;
		margin-bottom: 0;
	}

	p {
		color: white;
		margin-top: 5px;
	}

	/* Quest box styling */
	.box-quests {
		position: relative;
		margin: 35px 0 0 27px;
		padding: 20px;
		background: radial-gradient(circle at center, #395b77 0%, #263a4b 100%);
		border: solid;
		border-color: white;
		border-width: 2px;
		border-radius: 15px;
		box-shadow: 0 0 10px rgba(255, 255, 255, 0.6);
		overflow: hidden;
	}

	/* Box pseudo-elements for decorative borders */
	.box-quests::before,
	.box-quests::after {
		content: "";
		position: absolute;
		top: 0;
		bottom: 0;
		width: 5px;
		background-color: white;
	}

	.box-quests::before {
		left: 0;
		clip-path: polygon(0 10%, 100% 30%, 100% 70%, 0 90%);
	}

	.box-quests::after {
		right: 0;
		clip-path: polygon(100% 10%, 0 30%, 0 70%, 100% 90%);
	}

	/* Horizontal line in the box */
	hr.line1 {
		border-bottom: solid 3px white;
	}

	/* Points text styling */
	p.points {
		color: #9cf3ff;
		text-align: center;
	}

	/* Start quest button styling */
	.button-main {
		background-color: black;
		color: white;
		height: 50px;
		width: 250px;
		margin-left: 40px;
		border-radius: 10px;
		font-family: video, serif;
		font-style: normal;
		font-weight: 800;
		font-size: 24px;
	}

	/* Font-face definition for custom font */
	@font-face {
		font-family: "WebSymbolsRegular";
		src: url("http://html5css3demos.bplaced.net/css3-slider-v3/websymbols-regular-webfont.eot");
		src: url("http://html5css3demos.bplaced.net/css3-slider-v3/websymbols-regular-webfont.eot?#iefix")
				format("embedded-opentype"),
			url("http://html5css3demos.bplaced.net/css3-slider-v3/websymbols-regular-webfont.woff")
				format("woff"),
			url("http://html5css3demos.bplaced.net/css3-slider-v3/websymbols-regular-webfont.ttf")
				format("truetype"),
			url("http://html5css3demos.bplaced.net/css3-slider-v3/websymbols-regular-webfont#WebSymbolsRegular")
				format("svg");
	}

	/* Slideshow wrapper styling */
	#slideshow-wrap {
		display: block;
		height: 550px;
		max-width: 380px;
		margin: auto;
		margin-top: 50px;
		position: relative;
	}

	/* Slideshow inner container styling */
	#slideshow-inner {
		width: 100%;
		height: 100%;
		overflow: hidden;
		position: relative;
	}

	/* Slideshow inner list styling */
	#slideshow-inner > ul {
		list-style: none;
		height: 100%;
		width: 500%;
		overflow: hidden;
		position: relative;
		left: 0px;
		margin: 0;
		-webkit-transition: left 0.8s cubic-bezier(0.77, 0, 0.175, 1);
		-moz-transition: left 0.8s cubic-bezier(0.77, 0, 0.175, 1);
		-o-transition: left 0.8s cubic-bezier(0.77, 0, 0.175, 1);
		transition: left 0.8s cubic-bezier(0.77, 0, 0.175, 1);
	}

	/* Slideshow list item styling */
	#slideshow-inner > ul > li {
		width: 20%;
		height: 320px;
		float: left;
		position: relative;
	}

	/* Slideshow images styling */
	#slideshow-inner > ul > li > img {
		margin: auto;
		height: 100%;
		margin-top: -90px;
		scale: 1.65;
		margin-left: 15px;
	}

	/* Hide radio buttons for slideshow controls */
	#slideshow-wrap input[type="radio"] {
		position: absolute;
		left: 50%;
		bottom: 15px;
		z-index: 100;
		visibility: hidden;
	}

	/* Change background color of labels when active */
	#slideshow-wrap input[type="radio"]#button-1:checked ~ label[for="button-1"],
	#slideshow-wrap input[type="radio"]#button-2:checked ~ label[for="button-2"],
	#slideshow-wrap input[type="radio"]#button-3:checked ~ label[for="button-3"] {
		background-color: white;
	}

	/* Position labels for radio buttons */
	#slideshow-wrap label[for="button-1"] {
		margin-left: -36px;
	}

	#slideshow-wrap label[for="button-2"] {
		margin-left: -18px;
	}

	/* Slide position controls */
	#slideshow-wrap input[type="radio"]#button-1:checked ~ #slideshow-inner > ul {
		left: 0;
	}

	#slideshow-wrap input[type="radio"]#button-2:checked ~ #slideshow-inner > ul {
		left: -100%;
	}

	#slideshow-wrap input[type="radio"]#button-3:checked ~ #slideshow-inner > ul {
		left: -200%;
	}

	/* Navigation arrows styling */
	label.arrows {
		font-family: video, serif;
		font-size: 75pt;
		color: white;
		position: absolute;
		top: 76%;
		display: none;
		cursor: pointer;
		z-index: 1;
		background-color: transparent;
		-webkit-transition: opacity 0.2s;
		-moz-transition: opacity 0.2s;
		-o-transition: opacity 0.2s;
		transition: opacity 0.2s;
	}

	/* Show arrows on hover */
	label.arrows:hover {
		opacity: 1;
	}

	/* Adjust margin for active state of arrows */
	label.arrows:active {
		margin-top: -23px;
	}

	/* Display the appropriate arrows based on active radio button */
	input[type="radio"]#button-1:checked ~ .arrows#arrow-2,
	input[type="radio"]#button-2:checked ~ .arrows#arrow-3 {
		right: -6px;
		display: block;
	}

	/* Show left arrows and flip them horizontally */
	input[type="radio"]#button-2:checked ~ .arrows#arrow-1,
	input[type="radio"]#button-3:checked ~ .arrows#arrow-2 {
		left: -55px;
		display: block;
		-webkit-transform: scaleX(-1);
		-moz-transform: scaleX(-1);
		-ms-transform: scaleX(-1);
		-o-transform: scaleX(-1);
		transform: scaleX(-1);
	}

	/* Adjust left margin for specific slides */
	input[type="radio"]#button-2:checked ~ .arrows#arrow-1 {
		left: 31px;
	}

	input[type="radio"]#button-3:checked ~ .arrows#arrow-2 {
		left: 13px;
	}
}

@media only screen and (min-width: 769px) {
	.stars-bg-top {
		position: absolute;
		width: 100%;
		margin-top: -250px;
	}
}
</style>
