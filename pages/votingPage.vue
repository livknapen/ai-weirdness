<template>
    <div>
      <div id="textBox">
        <p>
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut dapibus viverra eros nec molestie. Quisque aliquam, ligula non dignissim dignissim, urna urna gravida dui, venenatis ultrices quam mauris in felis. Nulla neque nunc, porttitor nec tristique id, malesuada nec leo. Maecenas et arcu dui. Mauris eleifend convallis condimentum. Pellentesque facilisis massa non pulvinar dignissim. Praesent augue est, elementum vitae mi quis, pretium consequat mi. Quisque fringilla nulla sit amet leo convallis, in auctor lacus finibus. Phasellus vitae convallis odio. Maecenas sed sagittis mi, nec tincidunt leo. Curabitur bibendum at metus quis cursus
        </p>
        <button>Voting Guide</button>
      </div>
      <div class="box" style="height: 310px; width: 400px">
        <div id="presidentContainer">
          <div class="presidentItem">
            <h2>
              president human
            </h2>
            <img src="@/assests/Emily.png " alt="The Human President" style="height: 200px;">
            <button>Human</button>
          </div>
          <div class="presidentItem">
            <h2>
              president AI
            </h2>
            <img src="@/assests/Maichael.png" alt="The AI President" style="height: 200px;">
            <button>AI</button>
          </div>
        </div>
      </div>
    </div>
  </template>
  
  <script>
    import "@/assests/css/main.css" // Import the main css
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
  
  <style>
  body {
    background-color: #061929;
    color: white;
  }

  /* All buttons */
  button {
    height: 30px;
    width: 100px;
    align-self: center;
    margin-top: 10px;
    background-color: white;
    border-radius: 10px;
    border-color: black;
  }

  /* Top Text */
  #textBox {
    display: flex;
    flex-direction: column;
    margin: 20px;
  }

  /* Voting Guide Button */
  #textBox button {
    width: 150px;
    height: 50px;
  }

  /* President Selection */
  #presidentContainer {
    display: flex;
    flex-direction: row;
    justify-content: center;
  }

  .presidentItem {
    display: flex;
    flex-direction: column;
    margin-left: 10px;
    margin-right: 10px;
    text-align: center;
  }

  .presidentItem h2 {
    margin-top: 10px ;
  }
  </style>

