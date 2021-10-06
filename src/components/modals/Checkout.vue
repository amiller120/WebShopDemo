<template>
  <div>
    <div class="modal-container"> 
    <transition name="fade">
      <div v-if="modalOpen" class="modal">
        <slot></slot>
      </div>
    </transition>
    </div>
  </div>
</template>
<script>
export default {
    props:{
        modalOpen: {
            type: Boolean,
            required: false
        }
}
};
</script>
<style scoped>


.modal-container {
  display: flex;
  justify-content: center;
  margin-top: 10em;
  position: fixed;
  top: 0;
    bottom: 0;
    left: 0;
    right: 0;
    
}

.modal {
  width: 50em;
  height: 25em;
  box-shadow: rgba(0, 0, 0, 0.25) 0px 0.0625em 0.0625em,
    rgba(0, 0, 0, 0.25) 0px 0.125em 0.5em,
    rgba(255, 255, 255, 0.1) 0px 0px 0px 1px inset;
}

.fade-enter-from {
    opacity: 0;
}

.fade-enter-active,
.fade-leave-active{
    transition: opacity 0.5s ease-out;
}

.fade-leave-to {
    opacity: 0;
}
</style>