<template>
  <div class="background">
    <div class="container">
      <h1 class="header-text">{{ pageTitle }}</h1>
      <h1 class="header-text">Moon government</h1>
      <span class="body-text">The elections are coming up. Refer to the voting guide to help you take your stand!</span>
      <br>
      <button class="button-main">button test</button>
      <div class="box" style="height: 100px; width: 400px"></div>
    </div>
  </div>
</template>

<script>
import Pim from "@/components/Pim.vue"; // Import the Pim component
import "@/assests/css/main.css" // Import the main css 
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

<style>
* {
  padding: 0;
  margin: 0;
}
</style>


