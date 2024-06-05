<template>
	<div>
		<div v-if="error">no username</div>
		<div v-else-if="loading">Loading...</div>
		<div v-else>{{ username }}</div>
	</div>
</template>

<script lang="ts">
import { defineComponent, ref, onMounted } from "vue";

export default defineComponent({
	name: "Username",
	props: {
		userId: {
			type: String,
			required: true,
		},
	},
	setup(props) {
		const username = ref<string | null>(null);
		const loading = ref(true);
		const error = ref<string | null>(null);

		const fetchUsername = async () => {
			try {
				const response = await fetch(
					`https://localhost:7117/api/Users/${props.userId}`
				);
				if (!response.ok) {
					throw new Error("Network response was not ok");
				}
				const data = await response.json();
				username.value = data.username;
			} catch (err) {
				error.value = "Failed to fetch username";
			} finally {
				loading.value = false;
			}
		};

		onMounted(fetchUsername);

		return {
			username,
			loading,
			error,
		};
	},
});
</script>

<style scoped>
h1 {
	font-size: 2em;
	margin-bottom: 1em;
}
</style>
