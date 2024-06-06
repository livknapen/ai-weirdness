<template>
  <div>
    <div class="div-progressbar"></div>
    <div class="progress" :style="{ width: progress + '%' }"></div>
  </div>
</template>

<script>
// Exports the progress numbers
export default {
  props: {
    progress: {
      type: Number,
      required: true,
    },
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
  height: 22px;
  transition: width 0.3s ease;
  background-color: #344f65;
}
</style>
