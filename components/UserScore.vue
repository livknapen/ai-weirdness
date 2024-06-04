<template>
	<div>
		<div v-if="error">{{ error }}</div>
		<div v-else-if="loading">Loading...</div>
		<div v-else>{{ score }}</div>
	</div>
</template>

<script lang="ts">
import { defineComponent, ref, onMounted } from "vue";

export default defineComponent({
	name: "UserScore",
	props: {
		userId: {
			type: String,
			required: true,
		},
	},
	setup(props) {
		const score = ref<number | null>(null);
		const loading = ref(true);
		const error = ref<string | null>(null);

		const fetchUserScore = async () => {
			try {
				const response = await fetch(
					`https://localhost:7117/api/Users/${props.userId}`
				);
				if (!response.ok) {
					throw new Error("Network response was not ok");
				}
				const data = await response.json();
				score.value = data.score;
			} catch (err) {
				error.value = "Failed to fetch user score";
			} finally {
				loading.value = false;
			}
		};

		onMounted(fetchUserScore);

		return {
			score,
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
