<template>
  <div>
    <header>
      <h1 class="h1-head">voting guide</h1>
      <h2 class="h2-head">[ MENU ]</h2>
    </header>
      <img class="img-stars-top" src="/static/stars-top.png">
      <div class="div-maincontainer">
        <div class="white-box">
          <div class="div-progressbar">
            <label for="file-voting"></label>
            <progress id="file-voting" max="100" value="10">10%</progress>
          </div>
          <h1 class="h1-votingguide">{{ pageTitle }}</h1>
          <p class="p-votingguide">Stimulate the economic growth of our moon colony and create prosperity for all residents.</p>
          <div class="div-votingbuttons">
            <NuxtLink to="/voting"><button class="button-agree"> 
              <svg width="29" height="29" viewBox="0 0 29 29" fill="none" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink">
              <rect width="29" height="29" transform="matrix(1 0 0 -1 0 29)" fill="url(#pattern0_137_20)"/>
              <defs>
              <pattern id="pattern0_137_20" patternContentUnits="objectBoundingBox" width="1" height="1">
              <use xlink:href="#image0_137_20" transform="scale(0.0111111)"/>
              </pattern>
              <image id="image0_137_20" width="90" height="90" xlink:href="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAFoAAABaCAYAAAA4qEECAAAACXBIWXMAAAsTAAALEwEAmpwYAAACtElEQVR4nO3du49NURTH8eMVz4ZoEInX4B8Q0Sk1GiIYdHRkEp2OWqMg+ANEIfHINAoJIjEyHqNSKWQwM4SRGGJGhq+czKkk4j72WWvte36ff2DW+t19T85ZZ989RSEiIiIiIiIiIiIiFoB1wDHgKvAQGAe+4usb8AQ4BSzOdiUAi6pwHwC/iG2kXAxFToD5wHFglLyMZLOygW3V1zFXJ4vogMPAFHkbKiIDBjK4DrdiqoiABigioAGKCGiAIgKaYRDoBxYoaBsvgD6taBsTLmHTTM+AhQraxiEFbeOOgrYxrqBtzChoG2MK2sYtBW3jgIKu33D51khB1++MHlhsnw636BHcbu6xWbMOu5Vd//jUqJno6p97eHcYxKCCtjGhoHtl7mHUSHRvFHSvzD2MGoluv4Ku32OTuQfNNgpsqj1kBc1uk5AVNG8167AzpFmHHd11GNF9tBE9GRqZ1l2HjXcK2oau0UYOakXX76npHg9gObAB2AdcBj7R+z6UPZuF/I/glwKngS/07kreWEQBrAcekb9Z4D1wu7wmm28JawWwpPoJWUp93n2FBCyrvm6pDHj3FFa5CoEfiYK+691PaMC5REFPl3c63v2EBayoNgemsNe7n9CYOxwqhUveveRwiNXrBEG/8u4lPOAIaaz17iU0YB7wPEHQ/d69hAfsSRD0Re8+sgDc6zLo+949ZAHYAfzuIuiP3j1kA7jRRdCz3vVnA9gK/Oww6O/e9WcFuNJh0JPetWcFWFMdKxz73IxeAFwIuXml1zB3tnS7XnrXnR1gVwdB3/SuOzvA6g6CPu9dd5aAyTaD1ky6w6CH2wh5pnyRkPzTbgLgWhtBX/euN1vA2TbeGW73rjdbwNEWQi6HUCe8a80asPM/IX/WsD9N0Kv+CrbcBzJW7uOo/kHDyhR/x9sf2G5fDIrarFcAAAAASUVORK5CYII="/>
              </defs>
              </svg> </button></NuxtLink>
              <NuxtLink to="/voting"><button class="button-neither"> 
              <svg width="29" height="29" viewBox="0 0 29 29" fill="none" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink">
              <rect width="29" height="29" fill="url(#pattern0_294_430)"/>
              <defs>
              <pattern id="pattern0_294_430" patternContentUnits="objectBoundingBox" width="1" height="1">
              <use xlink:href="#image0_294_430" transform="scale(0.0111111 0.0215909)"/>
              </pattern>
              <image id="image0_294_430" width="90" height="90" xlink:href="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAFoAAABaCAYAAAA4qEECAAAACXBIWXMAAAsTAAALEwEAmpwYAAAEeUlEQVR4nO2cT4iXRRjH33JTdu1SlIKCEsSauBClop50wxWiP1e1QylehCCPoUSCB3+7SofcZD265imIioigQxJbehCJiE6lFey6iZq2ZJZufuTBEUT2nXfe953Zmdf3+Zz28ptnvs/7zsx3npl3s0xRFEVRFEVRFEWJB/AsMAScBC4D08Ak8AMwCmwFHo/YxWYD9AFf4cY/wGHgqdj9bgxAF/A28C/luQEMAvNi60gaYAHwHfX5EeiNrSdJgBXAr/jjCvBibF1JAawELuEfWTjfiK0vCYB1wFWHxe4D4DmgG1giCQROOCb79azNAKuBqYJEfQ08bWljA/CTwyI5kLUR4BngYkGCxEE87NDWPPPG25BR0+dbxCOmk38Ycy9/d2WJACwGfi8Y7tsrtLvL/DYPibnIp5ADMwQ5mCUAMB84Y0nGTWBLjfZfBa5Z2j8lL6IvMZM5AlZ4CVARmQaATyxJ+B/Y7CHOS0ZvHp26MWyJFr7wEsDvSLuXnR5j7QBuWR7oRh9Bhi1ioph47gi3sTdAzHct8c4DT9QNsNBim2T3Nd+bGgeAfmOx8jgGPJR5RtoEPrfF9RFkjyXAe16UOAAsA/609GUsZBEIeKzA4WyqG0B2UGdzGhcLtN6bmhxkaAK/WET+XHv4uo8omZdnQnLUXTfAC5YFYTykSGCu2dXlIUX8ZaHiz9Cf9y192e0jwIeWAJ8FnBuPW+LKfN3vO25Bnx61TCF/SYm2boAnLXZPeMebGgOwDzs7sggAL1v6NOwjwIBljrpVZbubB/BmQZKHsogAX+b0a8rL6JbdUMFQru2vgdcsD1T42KVINAsHDDPVQ/7zUg8yhSbZ5+fxN/BKzSRPW9o/DfRkCZBT6fvIZ4BFDlWztyq0u70gyb95rZrVxFjfUVMPkRH4qfjtEMf4RScawy6bCGCOQ/3iQqoHpSbh4XbJZnG0bYkxpxYbLG30At8UtCG26fmszcg5WsFwv8sJYBuw1LwBq4AR4HrB72TUrI2tMwmk9uvwZlc96l8TW19SiK0zifHFudgHDMli5lu53VOXMdmJxtaTNMZn173zNje2jsYgNzKNoZdLKy7IlnZ57H43FlMw3wIcBb43Rz83zV2Mb4H93u9JKIqiKIqiKA8K3Dk1HzI2sg4TunmyYJLjk0FbvNZC/Tf5fiZja0oSAhBbU5KgiZ4dNNGR3YVjmy60y41Q0l04tlmGdrgRSroLxzbL0A43QjnGHduUacGZrA1Qjk6s6ajxEGDhMgvsoOub7VNMj/mPLFdjrcIEcBcV+uDCFXNGWv7zCuAIkVdhEhjOZeJLzqp8nep6gi1MBBI50bBEXyt1d7tColMQOZHAwy6X6ApTRwqJ7iQwfY1UCdBt7jg73akLJNKF2ViQi9yIfGx6qPa3hqHFk4C7SA7KMdgUd9H0RE/Gql00nhCWiwC1i8aTQImyk7WBEDUB3GhX0d3TW+lEbE1JQgAyRRPdGDfiQDvcRQLXsTqxNT0QbsSCugtFURRFURRFURRFUZQsbW4DDY3qbZ4QD7kAAAAASUVORK5CYII="/>
              </defs>
              </svg> </button></NuxtLink>
              <NuxtLink to="/voting"><button class="button-disagree"> 
              <svg width="29" height="29" viewBox="0 0 29 29" fill="none" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink">
              <rect width="29" height="29" transform="matrix(-1 0 0 1 29 0)" fill="url(#pattern0_137_19)"/>
              <defs>
              <pattern id="pattern0_137_19" patternContentUnits="objectBoundingBox" width="1" height="1">
              <use xlink:href="#image0_137_19" transform="scale(0.0111111)"/>
              </pattern>
              <image id="image0_137_19" width="90" height="90" xlink:href="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAFoAAABaCAYAAAA4qEECAAAACXBIWXMAAAsTAAALEwEAmpwYAAACtElEQVR4nO3du49NURTH8eMVz4ZoEInX4B8Q0Sk1GiIYdHRkEp2OWqMg+ANEIfHINAoJIjEyHqNSKWQwM4SRGGJGhq+czKkk4j72WWvte36ff2DW+t19T85ZZ989RSEiIiIiIiIiIiIiFoB1wDHgKvAQGAe+4usb8AQ4BSzOdiUAi6pwHwC/iG2kXAxFToD5wHFglLyMZLOygW3V1zFXJ4vogMPAFHkbKiIDBjK4DrdiqoiABigioAGKCGiAIgKaYRDoBxYoaBsvgD6taBsTLmHTTM+AhQraxiEFbeOOgrYxrqBtzChoG2MK2sYtBW3jgIKu33D51khB1++MHlhsnw636BHcbu6xWbMOu5Vd//jUqJno6p97eHcYxKCCtjGhoHtl7mHUSHRvFHSvzD2MGoluv4Ku32OTuQfNNgpsqj1kBc1uk5AVNG8167AzpFmHHd11GNF9tBE9GRqZ1l2HjXcK2oau0UYOakXX76npHg9gObAB2AdcBj7R+z6UPZuF/I/glwKngS/07kreWEQBrAcekb9Z4D1wu7wmm28JawWwpPoJWUp93n2FBCyrvm6pDHj3FFa5CoEfiYK+691PaMC5REFPl3c63v2EBayoNgemsNe7n9CYOxwqhUveveRwiNXrBEG/8u4lPOAIaaz17iU0YB7wPEHQ/d69hAfsSRD0Re8+sgDc6zLo+949ZAHYAfzuIuiP3j1kA7jRRdCz3vVnA9gK/Oww6O/e9WcFuNJh0JPetWcFWFMdKxz73IxeAFwIuXml1zB3tnS7XnrXnR1gVwdB3/SuOzvA6g6CPu9dd5aAyTaD1ky6w6CH2wh5pnyRkPzTbgLgWhtBX/euN1vA2TbeGW73rjdbwNEWQi6HUCe8a80asPM/IX/WsD9N0Kv+CrbcBzJW7uOo/kHDyhR/x9sf2G5fDIrarFcAAAAASUVORK5CYII="/>
              </defs>
              </svg> </button></NuxtLink>
          </div>
          <div class="div-voting-text">
            <p class="p-voting-text">Agree</p>
            <p class="p-voting-text2">Neither</p>
            <p class="p-voting-text">Disagree</p>
          </div>
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
      pageTitle: "Economy", // Set the pageTitle data property so you can import it in the HTML. It's basically a variable
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

.div-progressbar {
  display: flex;
}

progress {
  border-radius: 58px; 
  width: 100%;
  height: 22px;
  border-color: black;
  border-style: solid;
  margin-top: 2rem;
}

progress::-webkit-progress-bar {
  background-color: white;
  border-radius: 58px;
}

progress::-webkit-progress-value {
  background-color: #344F65;
  border-radius: 58px;
}

label {
  font-size: 20px;
  font-weight: bold;
  display: block;
  margin: 20px 0;
}

.div-votingbuttons {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  margin-top: -2rem;
}

.button-agree {
  background-color: #17BA31;
  border: none;
  border-radius: 50%;
  display: flex;
  margin-top: 8rem;
  text-decoration: none;
  padding: 1.2rem;
}

.button-neither {
  background-color: #959595;
  border: none;
  border-radius: 50%;
  display: flex;
  margin-top: 8rem;
  text-decoration: none;
  padding: 1.2rem;
}

.button-disagree {
  background-color: #BA1717;
  border: none;
  border-radius: 50%;
  display: flex;
  margin-top: 8rem;
  text-decoration: none;
  padding: 1.2rem;
}

.div-voting-text {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  margin-left: 0.6rem;
  margin-top: 0.5rem;
}

.p-voting-text {
  font-family: video, serif;
  font-style: normal;
  font-weight: 400;
  font-size: 15px;
}

.p-voting-text2 {
  font-family: video, serif;
  font-style: normal;
  font-weight: 400;
  font-size: 15px;
  margin-left: 0.7rem;
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
