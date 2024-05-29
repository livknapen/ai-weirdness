<template>
	<header>
		<div class="div-header-mobile">
			<h1 class="h1-head">Title</h1>
			<h2 class="h2-head" @click="showMobileMenu">[ MENU ]</h2>
		</div>
		<div class="div-header-desktop">
			<h1 class="h1-head">Title</h1>
			<h2 class="h2-head">Home</h2>
			<h2 class="h2-head">Quests</h2>
			<h2 class="h2-head">Profile</h2>
			<h2 class="h2-head">Voting Guide</h2>
		</div>
	</header>
</template>

<script>
export default {
	methods: {
		showMobileMenu() {
			this.$emit("showMobileMenu");
		},
	},
};
</script>
