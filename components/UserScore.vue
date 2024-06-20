<!-- 
  This component fetches the user score from the API and displays it.
  It shows a loading message while fetching the data and an error message if the fetch fails.
-->

<template>
	<div>
		<!-- Display error message if there is one -->
		<div v-if="error">{{ error }}</div>
		<!-- Display loading message if still loading -->
		<div v-else-if="loading">Loading...</div>
		<!-- Display the score if there is no error and not loading -->
		<div v-else>{{ score }}</div>
	</div>
</template>

<script lang="ts">
import { defineComponent, ref, onMounted } from "vue";

export default defineComponent({
	name: "UserScore", // Component name
	props: {
		// Define the props
		userId: {
			// What we're using to fetch the score
			type: String, // The type of the prop
			required: true, // The prop is required
		},
	},
	setup(props) {
		const score = ref<number | null>(null); // The score constructor, either a number or null
		const loading = ref(true); // The loading constructor, either true or false. True by default
		const error = ref<string | null>(null); // The error constructor, either the error message or null

		// Component to fetch the score
		const fetchUserScore = async () => {
			// It will first try to fetch the score
			try {
				// Get the response from the API and store it in a variable called response
				const response = await fetch(
					`https://localhost:7117/api/Users/${props.userId}`
				);
				// If the response is not ok, throw an error "Network response was not ok"
				if (!response.ok) {
					throw new Error("Network response was not ok");
				}
				// Get the data from the response and store it as a json in a variable called data
				const data = await response.json();
				// Set the score value to the score from the data
				score.value = data.score;
				// If there is an error, set the error value to "Failed to fetch score"
			} catch (err) {
				error.value = "Failed to fetch user score";
				// Finally, set the loading value to false
			} finally {
				loading.value = false;
			}
		};

		onMounted(fetchUserScore); // Call the fetchUserScore method when the component is mounted

		// Return the username, loading, and error values
		return {
			score,
			loading,
			error,
		};
	},
});
</script>

<!-- Basic styling -->
<style scoped>
h1 {
	font-size: 2em;
	margin-bottom: 1em;
}
</style>
