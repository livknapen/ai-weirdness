<template>
    <div>
      <Header/>
    </div>
  </template>
  
  <script>
    import Header from "@/components/Header.vue"; 
    export default {
        components: {
            Header,
        },
        data() {
            return {
                pageTitle: "votingPage", 
            };
        },
    };
  </script>
  
  <style scoped>
  h1 {
    color: #333;
  }
  </style>

