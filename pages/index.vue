<template>
  <div>
    <h1>{{ pageTitle }}</h1>
    <p>Welcome to my Nuxt.js homepage!</p>
    <Pim />
    <NuxtLink to="/Quests">Quests</NuxtLink>
    <!-- This renders the Pim component -->
  </div>
</template>

<style scoped>
h1 {
  color: #333;
}
</style>
