<template>
	<link href="https://fonts.googleapis.com/css?family=Alata" rel="stylesheet" />
	<link href="https://fonts.cdnfonts.com/css/ethnocentric" rel="stylesheet" />
	<link rel="stylesheet" href="https://use.typekit.net/clw2vbx.css" />

	<div class="background">
		<img
			style="position: absolute; top: 0; left: 0; width: 100%; z-index: -101"
			src="/assets/images/stars-top-desktop.png"
			alt=""
		/>
		<MobileMenu
			v-show="showMobileMenu"
			@closeMobileMenu="showMobileMenu = false"
			style="position: relative; z-index: 100"
		/>
		<Navbar
			pageTitle="Home"
			@showMobileMenu="showMobileMenu = true"
			style="position: relative; z-index: 100"
		/>

		<div class="storyline">
			<video controls="" autoplay name="media">
				<source src="/assets/videos/AI-Weirdness-Trailer.mp4" />
			</video>
			<h2>Storyline</h2>
			<p>
				In the year 2034, life on earth has become more difficult than one would
				ever imagine. The climate is getting worse and worse, wars are raging,
				and the economy has never been less predictable.
			</p>
			<p>
				Scientists were able to discover ways to live on the moon, and
				construction for the first large city has almost been completed. The
				first humans have arrived to start this newly formed nation. Upon
				arrival, the new society was confronted with their first real problem.
				Who will decide what will happen in this nation and who will lay the
				foundation for this nation to build on.
			</p>
			<p>
				They all agreed that someone had to be the president of this nation, but
				who will it be? First, a relatively wealthy, experienced, and motivated
				person steps up, she wants to be the president. Many people agree that
				she should become president, but not everyone. Some people want a fresh
				start, a new beginning with something that has been unheard of, an AI
				president. The reason why an AI president could work is because of its
				impartiality and efficiency, making decisions based solely on data and
				processing information swiftly, enabling faster governance and
				innovative solutions.
			</p>
			<p>
				People start arguing over which one will be best, but no progress is
				being made, so everyone agrees that there should be elections to decide
				which one will be their president. To decide which candidate becomes
				president and creates the new society, the two sides will compete. Both
				sides will be having big campaigns to argue why they should become
				president. They talk about different social dilemmas, things they would
				improve, and all the benefits society would have when they get elected.
			</p>
			<p>
				In the end one president gets elected, he/she builds the nation and will
				be the main influence for society.
			</p>

			<div style="margin-top: 16px"></div>
		</div>
	</div>
</template>

<script>
import "/assets/css/main.css";
import "/assets/css/home.css";

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
	overflow: visible;
}
</style>
