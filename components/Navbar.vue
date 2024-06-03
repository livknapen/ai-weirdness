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

<style>
@media only screen and (max-width: 768px) {
  .div-header-mobile {
    display: flex;
    justify-content: space-between;
    margin-right: 2rem;
    margin-left: 2rem;
    flex-direction: row;
  }

  .div-header-desktop {
    display: none;
  }

  .h1-head {
    color: white;
    font-family: ethnocentric;
    margin-bottom: 2rem;
    font-size: 32px;
    margin-top: 4rem;
  }

  .h2-head {
    color: white;
    font-family: alata;
    margin-bottom: 2rem;
    font-size: 32px;
    margin-top: 4rem;
  }
}
@media only screen and (min-width: 769px) {
  .div-header-desktop {
    display: flex;
    justify-content: space-evenly;
    margin-right: 2rem;
    flex-direction: row;
    position: relative;
  }

  .div-header-mobile {
    display: none;
  }

  .h1-head {
    color: white;
    font-family: ethnocentric;
    margin-bottom: 2rem;
    font-size: 64px;
    margin-top: 3rem;
    margin-left: 2rem;
    margin-right: 11rem;
  }

  .h2-head {
    color: white;
    font-family: alata;
    font-style: normal;
    font-weight: 300;
    margin-bottom: 2rem;
    font-size: 32px;
    margin-top: 4rem;
  }
}
</style>
