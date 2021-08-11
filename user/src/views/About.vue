<template>
  <div class="about">
    <ul>
      <li v-for="element in elements" :key="element.id">
        {{element.displayName}}
      </li>
    </ul>
  </div>
</template>

<script>
import axios from "axios"
export default{
  name:"about",
  data() {
    return{
      elements: [
      ]
    };  
  },
  async created () {
    const res = await axios.get("https://localhost:5001/graph/user");
    this.elements = res.data
  }
};
</script>
