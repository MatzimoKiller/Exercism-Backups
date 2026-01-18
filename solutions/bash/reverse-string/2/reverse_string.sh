#!/usr/bin/env bash
input=$1
output=""
for (( i=0; i<${#input}; i++ )); do
  output=${input:$i:1}${output}
done
printf '%s\n' "$output"
