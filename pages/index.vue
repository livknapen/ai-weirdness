<template>
  <div>
    <header>
      <h1 class="h1-head">voting guide</h1>
      <h2 class="h2-head">[ MENU ]</h2>
    </header>
      <img class="img-stars-top" src="/static/stars-top.png">
      <div class="div-maincontainer">
        <div class="white-box">
          <h1 class="h1-votingguide">{{ pageTitle }}</h1>
          <p class="p-votingguide">With this voting guide, you’ll ultimately get a president who best suits your positions.</p>
          <NuxtLink to="/voting"><button class="button-getstarted">Get started</button></NuxtLink>
        </div>
      </div>
    <img class="img-stars-bottom" src="/static/stars-bottom.png">
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

.h1-head {
  color: white;
  font-family: ethnocentric;
  margin-bottom: 2rem;
  font-size: 32px;
  margin-top: 4rem;
  margin-right: 15rem;
  margin-left: 2rem;
  display: flex;
  position: absolute;
}

.h2-head {
  color: white;
  font-family: alata;
  margin-bottom: 2rem;
  font-size: 32px;
  margin-top: 4rem;
  margin-left: 17rem;
  display: flex;
  position: absolute;
}

.div-maincontainer {
  margin: 2rem;
  z-index: 1;
  position: absolute;
  margin-top: 0rem;
}

.img-stars-top {
  width: 100%;
  margin-top: 0rem;
}

.img-stars-bottom {
  width: 100%;
  margin-top: 33rem;
}

.h1-votingguide{
  color: #344F65;
  font-family: ethnocentric;
  margin-bottom: 2rem;
  font-size: 43px;
  margin-top: 2rem;
}

.p-votingguide {
  color: black;
  font-family: video, serif;
  font-style: normal;
  font-weight: 400;
  font-size: 29px;
}

.button-getstarted {
  color: white;
  background-color: black;
  font-family: video, serif;
  font-style: normal;
  font-weight: 400;
  font-size: 20px;
  border: none;
  border-radius: 10px;
  display: flex;
  margin-left: 4rem;
  margin-top: 8rem;
  padding: 0.5rem 2rem 0.5rem 2rem;
}

.white-box { 
  width: 18.75rem; 
  height: 35rem; 
  margin-left: auto; 
  margin-right: auto;   
  background: rgb(255, 255, 255);
  padding: 1.875rem;
  -webkit-border-radius: 5px;
  -moz-border-radius: 5px;
  -ms-border-radius: 5px;
  -o-border-radius: 5px;
  border-radius: 0px 58px 58px 58px;
}
</style>
