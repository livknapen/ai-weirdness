<template>
	<div class="login-container">
		<img class="top-image" src="/assets/images/login-top-mobile.png" alt="" />
		<h2>Welcome back!</h2>
		<div class="login-form-container">
      <!-- <div class="login-form-flex">
        <div class="login-form-slant-left"></div>
        <div class="login-form-slant-right"></div>
      </div> -->
			<Login />
		</div>

		<img class="bottom-image" src="/assets/images/login-bottom.png" alt="" />
	</div>
</template>

<script onload></script>

<style>
body {
	padding: 0;
	margin: 0;
	overflow: hidden;

	background: linear-gradient(
		180deg,
		rgba(7, 26, 43, 1) 0%,
		rgba(6, 25, 41, 1) 100%
	);
	background-repeat: no-repeat;
	height: 100dvh;
}
#__nuxt {
	padding: 0 35px;
}
.login-container {
	display: flex;
	justify-content: center;
	align-items: center;
	flex-direction: column;
	height: 70vh;

	.top-image {
		position: absolute;
		top: 0;
		margin-top: -50px;
		z-index: -100;
	}
	.bottom-image {
		position: absolute;
		bottom: 0;
		z-index: -100;
	}
}
h2 {
	color: white;
	text-align: center;
	font-size: 46px;
	text-transform: uppercase;

	font-family: ethnocentric, sans-serif;
	font-style: normal;
	font-weight: 100;
}

.login-form-container {
	border: solid white;
	border-width: 2px;
	padding: 48px 48px 19px 48px;
	border-radius: 15px;
	background: radial-gradient(#395b77, #263a4b);
}
/* .login-form-flex {
  position: relative;
}
.login-form-slant-left {
  position: absolute;
  height: 132px;
  width: 8px;
  top: 25px;
  left: 0;
  margin-left: -48px;
  background-color: white;
}
.login-form-slant-right {
  position: absolute;
  height: 132px;
  width: 8px;
  top: 25px;
  right: 0;
  margin-right: -48px;
  background-color: white;
} */
</style>
