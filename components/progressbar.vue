<template>
  <div>
    <div class="div-progressbar">
    </div>
    <div class="progress">

    </div>
  </div>
</template>
 
<script>
import optionbuttons from '@/components/OptionButtons.vue';
export default {
  components: {
    optionbuttons,
  },
};
</script>

<style>
.optionbutton {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  gap: 4px;
}

.div-progressbar {
  display: flex;
  width: 65%;
}

.progress {
  border-radius: 58px;
  width: 70%;
  height: 22px;
  border-color: black;
  border-style: solid;
  transition: width 0.3s ease;
  margin-left: 13%;
}

.progress::-webkit-progress-bar {
  background-color: white;
  border-radius: 58px;
}

.progress::-webkit-progress-value {
  background-color: #344F65;
  border-radius: 58px;
}


.div-button {
  display: flex;
  justify-content: center;
}

.div-votingbuttons {
  display: flex;
  flex-direction: row;
  justify-content: space-evenly;
  margin-top: 6rem;
}

.buttonagree {
  background-color: #17BA31;
  border: none;
  border-radius: 50%;
  display: flex;
  text-decoration: none;
  padding: 1.8rem;
  cursor: pointer;
}

.button-neither {
  background-color: #959595;
  border: none;
  border-radius: 50%;
  display: flex;
  text-decoration: none;
  padding: 1.8rem;
  cursor: pointer;
}

.button-disagree {
  background-color: #BA1717;
  border: none;
  border-radius: 50%;
  display: flex;
  text-decoration: none;
  padding: 1.8rem;
  cursor: pointer;
}
</style>
  