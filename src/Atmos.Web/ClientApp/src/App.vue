<template>
  <div id="app">
    <AppHeader title="ATMOS"/>
    <div id="app-contents">
      <div class="container">
            <LandingSection></LandingSection>
            <Mixer></Mixer>
      </div>
    </div>
  </div>
</template>

<script>
import AppHeader from './components/framework/AppHeader';
import Mixer from "./components/mixer/Mixer";
import LandingSection from "./components/landing/LandingSection";

export default {
  name: 'App',
  components: {
    Mixer,
    AppHeader,
    LandingSection
  }
}
</script>

<style>
  body {
    background-color: rgb(92, 229, 180);
    color: white;
  }
  h1, h2, h3, h4 {
    color: white;
  }
  #app-contents {
    margin-top: 3em;
  }
  .container {
    max-width: 750px;
  }
</style>
