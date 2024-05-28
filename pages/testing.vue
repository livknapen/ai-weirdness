<template>
  <div>
    <h1>Questionnaire</h1>
    <div v-if="currentQuestion < questions.length" class="question">
      <p>{{ questions[currentQuestion].text }}</p>
      <button @click="answerQuestion('agree')">Agree</button>
      <button @click="answerQuestion('neither')">Neither</button>
      <button @click="answerQuestion('disagree')">Disagree</button>
    </div>
    <div v-else>
      <div v-if="result !== null">
        <h2>Results</h2>
        <p>{{ result }}</p>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      questions: [
        { text: "In this new economy, vehicles and transportation based on fossil fuels should no longer be allowed." },
        { text: "Elderly people (65+) have a right to free public transport." },
        { text: "AI-Robots should be allowed to conduct life-threatening surgical operations." },
        { text: "A law should only be able to be approved by a human politician." },
        { text: "In order to combat climate change, all new buildings constructed should be required to incorporate renewable energy sources such as solar panels or wind turbines." },
        { text: "Mandatory voting should be implemented to ensure maximum participation in democratic processes." },
        { text: "Strict regulations should be imposed on the use of facial recognition technology by both government and private entities to protect citizens' privacy rights." },
        { text: "4% of the society’s GDP should go towards further space exploration." },
        { text: "The legal system should be based on restorative justice principles rather than punitive measures, focusing on rehabilitation and reconciliation." },
        { text: "Misgendering somebody on purpose should be considered an official offensive by law." }
      ],
      userAnswers: [],
      currentQuestion: 0,
      result: null,
      presidents: {
        presidenthuman: ['agree', 'neither', 'disagree', 'agree', 'neither', 'agree', 'disagree', 'neither', 'agree', 'disagree'],
        presidentai: ['disagree', 'agree', 'neither', 'disagree', 'agree', 'neither', 'agree', 'disagree', 'neither', 'agree']
      }
    };
  },
  methods: {
    answerQuestion(answer) {
      this.userAnswers[this.currentQuestion] = answer;
      this.currentQuestion++;
      if (this.currentQuestion === this.questions.length) {
        this.calculateResult();
      }
    },
    calculateResult() {
      const scores = { presidenthuman: 0, presidentai: 0 };

      this.userAnswers.forEach((answer, index) => {
        if (answer === this.presidents.presidenthuman[index]) {
          scores.presidenthuman++;
        }
        if (answer === this.presidents.presidentai[index]) {
          scores.presidentai++;
        }
      });

      if (scores.presidenthuman > scores.presidentai) {
        this.result = "You align more with President Human!";
      } else if (scores.presidentai > scores.presidenthuman) {
        this.result = "You align more with President AI!";
      } else {
        this.result = "You align equally with both presidents!";
      }
    }
  }
};
</script>

<style>
.question {
  margin-bottom: 20px;
}
</style>
