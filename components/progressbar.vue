<template>
  <div>
    <div class="div-progressbar">
    </div>
    <div class="progress" :style="{ width: progress + '%' }">

    </div>
  </div>
</template>
 
<script>
export default {
  props: {
    progress: {
      type: Number,
      required: true
    }
  }
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
  height: 22px;
  transition: width 0.3s ease;
  background-color: #344F65;
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
  