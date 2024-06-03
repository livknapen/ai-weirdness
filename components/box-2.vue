<template>
    <div class="quest-box">
      <div class="box" style="height: 313px; width: 335px">
        <h3>AI image vs Human image</h3><br>
        <hr class="line1"><br> 
        <p>In this quest you must pick between two images. Choose the image you think your president supports.</p><br>
        <p class="points">+1500 points</p><br>
        <NuxtLink to="/second-quest"><button class="button-main">Start Quest</button></NuxtLink>
    </div>
  </div>
</template>
  
<script>
  export default {
    name: "quest-box",
    data() {
      return {
        // Your component's data goes here
      };
    },
    computed: {
      // Your computed properties go here
    },
    methods: {
      // Your component's methods go here
    },
    mounted() {
      // Code to run when the component is mounted goes here
    },
    // Other component options (e.g., watch, lifecycle hooks) go here
  };
</script>
  
<style scoped>
  .quest-box {
    margin-left: -65px;
  }

  .box {
    position: relative;
    z-index: 5;
    margin: 0px 0 40px 27px;
    padding: 20px;
    background: radial-gradient(circle at center, #395B77 0%, #263A4B 100%);
    border: solid;
    border-color: white;
    border-width: 2px;
    border-radius: 15px;
    box-shadow: 0 0 10px rgba(255, 255, 255, 0.6);
    overflow: hidden;
  }

  .box::before, .box::after {
    content: "";
    position: absolute;
    top: 0;
    bottom: 0;
    width: 5px;
    background-color: white;
  }

  .box::before {
    left: 0;
    clip-path: polygon(0 10%, 100% 30%, 100% 70%, 0 90%);
  }

  .box::after {
    right: 0;
    clip-path: polygon(100% 10%, 0 30%, 0 70%, 100% 90%);
  }
</style>
  