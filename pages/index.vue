<template>
  <link href="https://fonts.googleapis.com/css?family=Alata" rel="stylesheet" />
  <link href="https://fonts.cdnfonts.com/css/ethnocentric" rel="stylesheet" />
  <link rel="stylesheet" href="https://use.typekit.net/clw2vbx.css" />
  <div>
    <header>
      <!-- Header -->
      <div class="div-header-mobile">
        <h1 class="h1-head">
          voting <br />
          guide
        </h1>
        <h2 class="h2-head">[ MENU ]</h2>
      </div>
      <div class="div-header-desktop">
        <h1 class="h1-head">voting guide</h1>
        <h2 class="h2-head">Home</h2>
        <h2 class="h2-head">Quests</h2>
        <h2 class="h2-head">Profile</h2>
        <h2 class="h2-head" style="color: #9cf3ff">Voting Guide</h2>
      </div>
    </header>
    <!-- Stars image top -->
    <img class="img-stars-top-mobile" src="/assets/stars-top.png" />
    <img class="img-stars-top-desktop" src="/assets/stars-top-desktop.png" />
    <div class="div-maincontainer">
      <div class="white-box">
        <!-- Import the pagetitle variable -->
        <h1 class="h1-votingguide">{{ pageTitle }}</h1>
        <p class="p-votingguide">
          With this voting guide, you’ll ultimately get a president who best
          suits your positions.
        </p>
        <!-- Button to go to the voting page -->
        <div class="div-button">
          <NuxtLink to="/voting"
            ><button class="button-getstarted">Get started</button></NuxtLink>
        </div>
      </div>
    </div>
    <!-- Stars image bottom -->
    <div class="div-stars-bottom">
      <img class="img-stars-bottom-mobile" src="/assets/stars-bottom.png" />
      <img
        class="img-stars-bottom-desktop"
        src="/assets/stars-bottom-desktop.png"
      />
    </div>
  </div>
</template>

<script>
// Import the whitebox
import WhiteBox from "@/components/WhiteBox.vue";
export default {
  components: {
    WhiteBox, 
  },
  data() {
    return {
      // Setting the variable for the pagetitle
      pageTitle: "Voting guide",
    };
  },
};
</script>
