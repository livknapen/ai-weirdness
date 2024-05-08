<template>
  <div>
    <h1>{{ pageTitle }}</h1>
    <p>Welcome to my Nuxt.js homepage!</p>
    <Pim />
    <NuxtLink to="/about">About</NuxtLink>
    <!-- This renders the Pim component -->
  </div>
</template>

<script>
import Pim from "@/components/Pim.vue"; // Import the Pim component
export default {
  components: {
    Pim, // Register the Pim component
  },
  data() {
    return {
      pageTitle: "Home", // Set the pageTitle data property so you can import it in the HTML. It's basically a variable
    };
  },
};
</script>

<style scoped>
h1 {
  color: #333;
}
</style>
