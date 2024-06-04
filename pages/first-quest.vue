<template>
	<link href="https://fonts.googleapis.com/css?family=Alata" rel="stylesheet" />
	<link href="https://fonts.cdnfonts.com/css/ethnocentric" rel="stylesheet" />
	<link rel="stylesheet" href="https://use.typekit.net/clw2vbx.css" />

	<div>
		<!-- Top background stars image -->
		<img
			class="stars-bg-top-quests"
			src="/assets/images/stars.svg"
			alt="Stars"
		/>

		<!-- Header text section -->
		<div class="header-text-quest">
			<h3>AI image vs Human image</h3>
			<p>Which side do you support.</p>
		</div>

		<div class="box-quest" style="height: 350px; width: 350px">
			<img src="/assets/images/first-quest.svg" />
		</div>

		<NuxtLink to="/Quests"
			><button class="button-main-quest">AI</button></NuxtLink
		>
		<NuxtLink to="/Quests"
			><button class="button-main-quest">Human</button></NuxtLink
		>

		<!-- Bottom background stars image -->
		<div class="stars-bg-bottom">
			<img class="stars-bg" src="/assets/images/stars-bottom.svg" alt="Stars" />
		</div>
	</div>
</template>

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

/* Top and bottom stars background positioning */
.stars-bg-top-quests {
	margin-top: -50px;
}

.stars-bg-bottom {
	position: relative;
}

.stars-bg {
	position: fixed;
	bottom: 0px;
}

/* Header text styling */
.header-text-quest {
	text-align: center;
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
.box-quest {
	position: relative;
	margin: 35px 0 0 40px;
	border: solid;
	border-color: white;
	border-width: 2px;
	border-radius: 15px;
	box-shadow: 0 0 10px rgba(255, 255, 255, 0.6);
	overflow: hidden;
}

/* Box pseudo-elements for decorative borders */
.box-quest::before,
.box-quest::after {
	content: "";
	position: absolute;
	top: 0;
	bottom: 0;
	width: 5px;
	background-color: white;
}

.box-quest::before {
	left: 0;
	clip-path: polygon(0 10%, 100% 30%, 100% 70%, 0 90%);
}

.box-quest::after {
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
.button-main-quest {
	background-color: black;
	color: white;
	height: 70px;
	width: 150px;
	margin-top: 50px;
	margin-left: 45px;
	border-radius: 50px;
	font-family: video, serif;
	font-style: normal;
	font-weight: 800;
	font-size: 24px;
}
</style>
