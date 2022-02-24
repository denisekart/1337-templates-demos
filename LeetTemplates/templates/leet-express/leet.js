const random = () => Math.floor(Math.random() * 100);

const _weights = [100, 300, 500, 700, 900];
const _sizes = [1, 2, 3, 5, 7];
const _colors = ["#05e273", "#0c0c91", "#000", "#05e273"];

module.exports = {
  addLeetWeights: (value) => `<span style="font-weight:${_weights[random()%_sizes.length]};">${value}</span>`,
  addLeetSizes: (value) => `<span style="font-size:${_sizes[random()%_sizes.length]}rem;font-family: Arial, sans-serif;">${value}</span>`,
  addLeetColors: (value) => `<span style="color:${_colors[random()%_colors.length]};">${value}</span>`,
};
