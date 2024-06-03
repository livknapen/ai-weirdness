<template>
  <link href='https://fonts.googleapis.com/css?family=Alata' rel='stylesheet'>
  <link href="https://fonts.cdnfonts.com/css/ethnocentric" rel="stylesheet">
  <link rel="stylesheet" href="https://use.typekit.net/clw2vbx.css">

  <div>
    <!-- Top background stars image -->
    <img class="stars-bg-top-quests" src="/img/stars.svg" alt="Stars" />

    <!-- Header text section -->
    <div class="header-text-quest">
        <h3>AI image vs Human image</h3>
        <p>Which side do you support.</p>
    </div>

    <div class="box-quest" style="height: 350px; width: 350px">
      <img src="/img/third-quest.svg">
    </div>

    <NuxtLink to="/Quests"><button class="button-main-quest">AI</button></NuxtLink>
    <NuxtLink to="/Quests"><button class="button-main-quest">Human</button></NuxtLink>

  
    <!-- Bottom background stars image -->
    <div class="stars-bg-bottom">
      <img class="stars-bg" src="/img/stars-bottom.svg" alt="Stars" />
    </div>
  </div>
</template>

<style>
 
</style>
  