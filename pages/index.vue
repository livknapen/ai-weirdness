<template>
  <link href='https://fonts.googleapis.com/css?family=Alata' rel='stylesheet'>
  <link href="https://fonts.cdnfonts.com/css/ethnocentric" rel="stylesheet">
  <link rel="stylesheet" href="https://use.typekit.net/clw2vbx.css">
  <div>
    <header>
      <div class="div-header-mobile">
        <h1 class="h1-head">voting <br> guide</h1>
        <h2 class="h2-head">[ MENU ]</h2>
      </div>
      <div class="div-header-desktop">
        <h1 class="h1-head">voting guide</h1>
        <h2 class="h2-head">Home</h2>
        <h2 class="h2-head">Quests</h2>
        <h2 class="h2-head">Profile</h2>
        <h2 class="h2-head" style="color: #9CF3FF;">Voting Guide</h2>
      </div>
    </header>
    <img class="img-stars-top-mobile" src="/assets/stars-top.png">
    <img class="img-stars-top-desktop" src="/assets/stars-top-desktop.png">
    <div class="div-maincontainer">
      <div class="white-box">
        <h1 class="h1-votingguide">{{ pageTitle }}</h1>
        <p class="p-votingguide">With this voting guide, you’ll ultimately get a president who best suits your positions.
        </p>
        <div class="div-button">
          <NuxtLink to="/voting"><button class="button-getstarted">Get started</button></NuxtLink>
        </div>
      </div>
    </div>
    <img class="img-stars-bottom-mobile" src="/assets/stars-bottom.png">
    <img class="img-stars-bottom-desktop" src="/assets/stars-bottom-desktop.png">
  </div>
</template>





<script>
import WhiteBox from "@/components/WhiteBox.vue"; // Import the WhiteBox component
export default {
  components: {
    WhiteBox, // Register the WhiteBoxe component
  },
  data() {
    return {
      pageTitle: "Voting guide", // Set the pageTitle data property so you can import it in the HTML. It's basically a variable
    };
  },
};
</script>

<style>
* {
  padding: 0;
  margin: 0;
}

body {
  background-color: #061929;
}

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
    font-family: 'Ethnocentric Rg';
    margin-bottom: 2rem;
    font-size: 32px;
    margin-top: 4rem;
  }

  .h2-head {
    color: white;
    font-family: 'Alata';
    font-style: normal;
    font-weight: 400;
    margin-bottom: 2rem;
    font-size: 32px;
    margin-top: 4rem;
  }

  .div-maincontainer {
    z-index: 1;
    position: absolute;
    width: 100%;
    margin-top: 2rem;
    display: flex;
    flex-direction: row;
    justify-content: center;
  }

  .img-stars-top-mobile {
    width: 100%;
    margin-top: -11rem;
    position: absolute;
    z-index: -1;
  }

  .img-stars-bottom-mobile {
    width: 100%;
    margin-top: 30rem;
  }

  .img-stars-top-desktop {
    display: none;
  }

  .img-stars-bottom-desktop {
    display: none;
  }

  .white-box {
    width: 71%;
    height: auto;
    background: rgb(255, 255, 255);
    padding: 1.875rem;
    border-radius: 0px 58px 58px 58px;
    margin-left: 2rem;
    margin-right: 2rem;
  }

  .h1-votingguide {
    color: #344F65;
    font-family: 'Ethnocentric Rg';
    margin-bottom: 1rem;
    font-size: 43px;
    margin-top: 2rem;
  }

  .p-votingguide {
    color: black;
    font-family: 'video';
    font-style: normal;
    font-weight: 400;
    font-size: 29px;
    margin-bottom: 5rem;
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
    font-family: 'Ethnocentric Rg';
    margin-bottom: 2rem;
    font-size: 64px;
    margin-top: 3rem;
    margin-left: 2rem;
    margin-right: 11rem;
  }

  .h2-head {
    color: white;
    font-family: 'Alata';
    font-style: normal;
    font-weight: 300;
    margin-bottom: 2rem;
    font-size: 32px;
    margin-top: 4rem;
  }

  .div-maincontainer {
    z-index: 1;
    position: absolute;
    width: 100%;
    margin-top: -14rem;
    display: flex;
    flex-direction: row;
    justify-content: center;
  }

  .img-stars-top-desktop {
    width: 100%;
    margin-top: -10rem;
    height: 30rem;
  }

  .img-stars-top-mobile {
    display: none;
  }

  .img-stars-bottom-desktop {
    width: 100%;
    margin-top: 0rem;
    height: 30rem;
  }

  .img-stars-bottom-mobile {
    display: none;
  }

  .white-box {
    width: 71%;
    height: auto;
    background: rgb(255, 255, 255);
    padding: 1.875rem;
    border-radius: 0px 58px 58px 58px;
    margin-left: 2rem;
    margin-right: 2rem;
  }

  .h1-votingguide {
    color: #344F65;
    font-family: 'Ethnocentric Rg';
    margin-bottom: 2rem;
    font-size: 45px;
    margin-top: 4rem;
    margin-left: 4rem;
  }

  .p-votingguide {
    color: black;
    font-family: 'Video';
    font-style: normal;
    font-weight: 400;
    font-size: 33px;
    margin-left: 4rem;
    margin-right: 7rem;
    margin-bottom: 8rem;
  }

  label {
    font-size: 20px;
    font-weight: bold;
    display: block;
    margin: 20px 0;
  }

  .button-getstarted {
    color: white;
    background-color: black;
    font-family: video, serif;
    font-style: normal;
    font-weight: 400;
    font-size: 35px;
    border: none;
    border-radius: 10px;
    padding: 1rem 5rem;
    cursor: pointer;
  }

  .div-button {
    display: flex;
    justify-content: center;
  }
}
</style>
